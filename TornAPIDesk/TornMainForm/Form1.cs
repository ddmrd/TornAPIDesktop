using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;



namespace TornMainForm
{
    public partial class MainForm : Form
    {
        public static string APIKey = null; // api key 
        public MainForm()
        { 
            InitializeComponent();
        }

        private void TornAPIKey_TextChanged(object sender, EventArgs e)
        {
            MainForm.APIKey = TornAPIKey.Text; // api key assgined
        }        
        
        private void ApiKeyLockcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ApiKeyLockcbx.Checked == true)
            {
                TornAPIKey.ReadOnly = true;
            }
            if (ApiKeyLockcbx.Checked == false)
            {
                TornAPIKey.ReadOnly = false;
            }
        }
        
        public static class MyFunctions
        {
     /// <summary>
     /// switch options: 1 = user , 2 = property , 3 = faction , 4 = company , 5 = market , 6 = torn. fields = The api options (children) from the switch description option.
     /// </summary>
     /// <param name="switchOption"></param>
     /// <param name="feilds"></param>
     /// <returns></returns>
     public static string FetchUserData(int switchOption,string fields) // function to request and receive API data.
            {
            string  test = null;
                switch (switchOption)
                {
                    case 1:
                         test = string.Format("https://api.torn.com/user/?selections=" + fields + "&key=" + MainForm.APIKey);
                        break;
                    case 2: 
                         test = string.Format("https://api.torn.com/property/?selections=" + fields + "&key=" + MainForm.APIKey);
                        break;
                    case 3:
                        test = test = string.Format("https://api.torn.com/faction/?selections=" + fields + "&key=" + MainForm.APIKey);
                        break;
                    case 4:
                        test = string.Format("https://api.torn.com/company/?selections=" + fields + "&key=" + MainForm.APIKey);
                        break;
                    case 5:
                         test = string.Format("https://api.torn.com/market/?selections=" + fields + "&key=" + MainForm.APIKey);
                        break;
                    case 6:
                        test = test = string.Format("https://api.torn.com/torn/?selections=" + fields + "&key=" + MainForm.APIKey);
                        break;

                }                               

                WebRequest RequestBasic = WebRequest.Create(test);
                RequestBasic.Method = "GET";
                HttpWebResponse ResponseBasic = null;
                ResponseBasic = (HttpWebResponse)RequestBasic.GetResponse();

                string strresulttest = null;
                using (Stream stream = ResponseBasic.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    strresulttest = sr.ReadToEnd();                   
                    UserData.Basic = strresulttest;
                    sr.Close();

                    return strresulttest;
                }
            }

            public static void TimerCountdownWithTicks(JToken JsonFrom,Label YourLabal,string JsonStringdataname)
            {
                if (Convert.ToInt32(JsonFrom[JsonStringdataname]) > 1)
                {
                    TimeSpan TimeTick = new TimeSpan();
                    JsonFrom[JsonStringdataname] = Convert.ToInt32(JsonFrom[JsonStringdataname]) - 1;
                    string TickDown = Convert.ToString(Convert.ToInt32(JsonFrom[JsonStringdataname]) - 1);
                    TimeTick = TimeSpan.FromSeconds(Convert.ToInt32(TickDown));
                    YourLabal.Text = String.Format(Convert.ToString(TimeTick), "MM:ss");
                }
            }
            /// <summary>
            /// Function limited to one parent hierarchy. FromwhatParent should equal the top hierarchy name inside the API called. The child can only be one step away/down from parent.  
            /// </summary>
            /// <param name="DictToStore"></param>
            /// <param name="FromWhatParent"></param>
            /// <param name="TheChildYouWant"></param>            
            /// <param name="VartoPullStoredJsonDataFrom"></param>
            /// <param name="knownIdUpperInt"></param>
            public static void AddJsonDataToDictionary(Dictionary<string,string> DictToStore,string FromWhatParent,string TheChildYouWant,string VartoPullStoredJsonDataFrom,int knownIdUpperInt) // get values from parent and add them to dictionary.
                 {

                string datacollected = VartoPullStoredJsonDataFrom;  // fetching api url data
                var readabledata = JObject.Parse(datacollected);
                var Id = JObject.Parse(Convert.ToString(readabledata));
                var f = JObject.Parse(Convert.ToString(Id[FromWhatParent]));
                
                for (int i = 0; i < knownIdUpperInt; i++)
                {
                    try
                    {
                        var j = JObject.Parse(Convert.ToString(f[Convert.ToString(i)]));
                        DictToStore.Add(Convert.ToString(i), (Convert.ToString(j[TheChildYouWant])));
                    }
                    catch (Exception)
                    {
                        continue;
                    }                                     
                }

            }
           
        }
        public class FileReadWriteLocations
        {
            public static string FileToSaveItemList = null;
        }

        public class TornData //variables to store Data obtained from Torn API
        {
            public static Dictionary<string, string> StocksIDandNames = new Dictionary<string, string>(); // value to store stock ID and Names for ID value.
            public static Dictionary<string, string> StockIDandCurrentPrice = new Dictionary<string, string>(); // value to store stock ID and CurrentPrice.
            public static Dictionary<string, string> StockIDandAvailableshares = new Dictionary<string, string>();
            public static Dictionary<string, string> StockIdandForecast = new Dictionary<string, string>();
            public static Dictionary<string, string> StockIdandDemand = new Dictionary<string, string>();
            public static Dictionary<string, string> StockIdandacronym = new Dictionary<string, string>();
            public static Dictionary<string, string> ItemsIdAndName = new Dictionary<string, string>();
            public static string TornStockInfo = null;
            public static string TornTime = null;
            public static string TornItemInfo = null;
            public static string TornJsonFetchedInfo = null;


        }

        public  class UserData // variables to store Data obtained from user API
        {
            public static JToken Notifications = null;        
            public static string Basic = null; // value to become json string
            public  static JObject User = null; // contain feteched user data from json string
            public static  string level = null;
            public static string gender = null;
            public static string name = null;
            public static JToken Bank = null;
            public static string player_id = null;
            public static string status = null; // Value will be based on the status from the profile API 
            public static JToken Chainjson = null; // will contain all details about the Chain bar
            public static JToken Lifejson = null; // will contain all details about the life bar
            public static JToken Nervejson = null; // will contain all details about the nerve bar
            public static JToken Energyjson = null; // will contain all details about the energy bar
            public static JToken Happyjson = null; // will contain all details about the happy bar
            public static JToken factionjson = null; // will contain details of the users faction name. Value is fetched from profile API
            public static JToken companyJson = null;
            public static JToken money = null;
            public static JToken DBMCooldowns = null;            
            public static string ChainCooldowns = null;
                      
            public static long TimerAble = 0; // when timerable is > 0 the refreshtimer will automate itself. when an exception occurs value is put to 0 which turns timer off.
            public static string StatusLink = null;
            public static TimeSpan ts = TimeSpan.FromSeconds(0) ;
            public static string SetValue(string jsonString,string StoreVar,string FetchedValue) // fetch value for data you want and name to store it as. level/gender ect..
                
            {
              var Js =  JObject.Parse(jsonString); // make json an var array?
                StoreVar = Convert.ToString(Js[FetchedValue]); // setvalue becomes the json feteched value
                return StoreVar; // return value so we can also set textbox value as the function. quicker assign.
            }
        }

        private void button1_Click(object sender, EventArgs e) // fetching Tab 1 Data
        {
            try
            {
                if (UserData.TimerAble == 0) // stops timer if exception occured. although if api is fixed within its interval will continue as normal or untill clicked again.
                {
                    Refreshtimer.Stop();
                }
                if (APIKey.Length == 16)
                {
                    APILengthWarning.Visible = false; // turn off API warning label 

                    ButtonLimittimer.Start();
                    GetDatabtn.Enabled = false;

                    OneSecondtimer.Start();
                    GetDatabtn.Text = Convert.ToString(ButtonLimittimer.Interval / 1000);

                    UserData.Basic = MyFunctions.FetchUserData(1, "basic,profile,bars,money,cooldowns,notifications"); // Fields to fetch

                    UserData.User = JObject.Parse(UserData.Basic); // parse to fetchable jtoken data.
                    var details = JObject.Parse(UserData.Basic); // makes json string data callable. 

                    lvlValuelbl.Text = UserData.SetValue(UserData.Basic, UserData.level, "level");
                    GenderValuelbl.Text = UserData.SetValue(UserData.Basic, UserData.gender, "gender");
                    NameValuelbl.Text = Convert.ToString(details["name"]);
                    IDValuelbl.Text = Convert.ToString(details["player_id"]);
                    TornData.TornTime = Convert.ToString(details["server_time"]); 
                    UserData.ChainCooldowns = Convert.ToString(details["cooldowns"]);

                    string status = Convert.ToString(details["status"]).Trim(new char[] { '[', ']', ' ', ',', '"', '.' }).Replace("\"", string.Empty).Replace(",", string.Empty);

                    Statuslbl.Text = "Status: " + status;
                    UserData.Lifejson = details["life"]; LifeValue.Text = Convert.ToString(UserData.Lifejson["current"] + " / " + UserData.Lifejson["maximum"]);
                    UserData.Energyjson = details["energy"]; EnergyValuelbl.Text = Convert.ToString(UserData.Energyjson["current"] + " / " + UserData.Energyjson["maximum"]);
                    UserData.Nervejson = details["nerve"]; NerveValuelbl.Text = Convert.ToString(UserData.Nervejson["current"] + " / " + UserData.Nervejson["maximum"]);
                    UserData.Happyjson = details["happy"]; HappyValuelbl.Text = Convert.ToString(UserData.Happyjson["current"] + " / " + UserData.Happyjson["maximum"]);
                    UserData.Chainjson = details["chain"]; ChainValuelbl.Text = Convert.ToString(UserData.Chainjson["current"]);
                    UserData.factionjson = details["faction"];
                    UserData.companyJson = details["job"];
                    // Points, money values
                    PointsValuelbl.Text = "Points " + Convert.ToString(String.Format("{0:n0}", UserData.User["points"]));
                    MoneyOnHandlbl.Text = "Money on hand: " + Convert.ToString("$" + String.Format("{0:n0}", UserData.User["money_onhand"]));
                    MoneyInVaultlbl.Text = "Money in Vault: " + Convert.ToString("$" + String.Format("{0:n0}", UserData.User["vault_amount"]));
                    CaymanbankValuelbl.Text = "Money in Cayman's: " + Convert.ToString("$" + String.Format("{0:n0}", UserData.User["cayman_bank"]));
                    UserData.Bank = UserData.User["city_bank"]; // bank values 
                    CityBankValuelbl.Text = "Money in Bank: " + Convert.ToString("$" + String.Format("{0:n0}", UserData.Bank["amount"]));
                    CoolDownValuelbl.Text = Convert.ToString(UserData.Chainjson["cooldown"]);
                    UserData.DBMCooldowns = details["cooldowns"];
                    UserData.Notifications = details["notifications"]; 
                    NewEventValuelbl.Text = "New Events ["+ Convert.ToString(UserData.Notifications["events"])+"]";
                    NewMessagesValuelbl.Text = "New Messages [" + Convert.ToString(UserData.Notifications["messages"])+"]";

                    ChainTimeOutValuelbl.Text = Convert.ToString(UserData.Chainjson["timeout"]);

                    //   StatusValuelbl.Location.Y.Equals(StatusValuelbl.Location.Y - 40);                

                    ApiKeyLockcbx.Checked = true;
                    UserData.TimerAble += 1; // when timerable is > 0 the refreshtimer will automate itself. when an exception occurs value is put to 0 which turns timer off.

                    int f = Refreshtimer.Interval / 1000; // value of refresh rate

                    RefreshValuelbl.Text = Convert.ToString(f);
                    OneSecondtimeTwo.Start(); // this timer should turn on last to prevent errors. 
                    if (UserData.TimerAble > 0)
                    {
                        Refreshtimer.Start();
                    }
                }
                if (APIKey.Length != 16)
                {
                    APILengthWarning.Visible = true;
                }
                
            }
            catch (Exception)
            {               
                MessageBox.Show("Enter valid API key"); 
                OneSecondtimeTwo.Stop();
                UserData.TimerAble = 0; // when timerable is > 0 the refreshtimer will automate itself. when an exception occurs value is put to 0 which turns timer off. value is increased by button press
            }
        }

        private void VisitTornlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.torn.com");
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            GetDatabtn.PerformClick();
        }

        private void ButtonLimittimer_Tick(object sender, EventArgs e)
        {
            GetDatabtn.Enabled = true;
            ButtonLimittimer.Stop();
        }

        private void OneSecondtimer_Tick(object sender, EventArgs e) // this timer is for the GetData button
        {
            GetDatabtn.Text = Convert.ToString( Convert.ToInt16(GetDatabtn.Text) -1); // changing datatext value to decrease by 1 per second
            if (Convert.ToInt32( GetDatabtn.Text) < 1 )
            {
                OneSecondtimer.Stop();
                GetDatabtn.Text = "GetData"; // reset text to original which indicates purpose
            }
        }

        private void OneSecondtimeTwo_Tick(object sender, EventArgs e) // timer for each second passing
        { 
            MyFunctions.TimerCountdownWithTicks(UserData.Energyjson, EnergyIncrementlbl, "ticktime");
            MyFunctions.TimerCountdownWithTicks(UserData.Nervejson, NerveTimerValuelbl, "ticktime");
            MyFunctions.TimerCountdownWithTicks(UserData.Lifejson, LifeTickValuelbl, "ticktime");
            MyFunctions.TimerCountdownWithTicks(UserData.Happyjson, HappyTickValuelbl, "ticktime");
            MyFunctions.TimerCountdownWithTicks(UserData.DBMCooldowns ,DrugCooldownValuelbl, "drug");
            MyFunctions.TimerCountdownWithTicks(UserData.DBMCooldowns, MedicalCooldownValue, "medical");
            MyFunctions.TimerCountdownWithTicks(UserData.DBMCooldowns, BoosterCdValuelbl, "booster");
            MyFunctions.TimerCountdownWithTicks(UserData.Chainjson, CoolDownValuelbl, "cooldown");
            MyFunctions.TimerCountdownWithTicks(UserData.Bank, BankTimeLeftValuelbl, "time_left");
                            
            if (Convert.ToInt32( ChainTimeOutValuelbl.Text) > 0)
            {
                ChainTimeOutValuelbl.Text = Convert.ToString(Convert.ToInt32(ChainTimeOutValuelbl.Text) - 1) ;
            }
            
            if (Statuslbl.Text.Contains('<')) // shortens status attacking info to link to attackers profile.
            {
                string statusBegin = Statuslbl.Text.Split('<')[0];
                string statusend = Statuslbl.Text.Split('\\')[1];
               Statuslbl.Text = statusBegin;
                
                UserData.StatusLink = "https://www.torn.com/" + statusend;
              StatusLinkProfileValuelbl.Text = statusend;
           /*    int CountStr = statusBegin.Count();
                int endstr = "https://www.torn.com/".Count() + statusend.Count();
                StatusLinkProfileValuelbl.Links.Add.(CountStr,endstr+1,UserData.StatusLink);*/ // this line currently throws error "over lapping link"
              StatusLinkProfileValuelbl.Visible = true;               

            }
         
            RefreshValuelbl.Text = Convert.ToString( Convert.ToInt32(RefreshValuelbl.Text) -1); // decrease refresh value by 1 per timer tick which should be 1 second.

            try
            {                
                DateTime begginingoftime = new DateTime(1970, 01, 01);
                 
             var details = JObject.Parse(Convert.ToString(UserData.User));
                TornData.TornTime = Convert.ToString( Convert.ToInt64(TornData.TornTime) + 1);
                TimeSpan torntime = TimeSpan.FromSeconds(Convert.ToUInt64(TornData.TornTime) +1);
                begginingoftime = begginingoftime +  torntime;
                TornCityTimelbl.Text = Convert.ToString("TCT: "  + begginingoftime);              

            }
            catch (Exception)
            {
                TornCityTimelbl.Text = "0";
            }

        }

        private void StatusLinkProfileValuelbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(UserData.StatusLink);
        }
        ///////////////////////////////////////////////////Tab 2 Start////////////////////////////////////////////////////////////////

        private void StockGetDatabtn_Click(object sender, EventArgs e)
        {
            new Thread(() => // new thread is used for more cpu intense tasks. this will allow the user constant app use as its main thread will not be too busy.
          {
          TornData.TornJsonFetchedInfo = MyFunctions.FetchUserData(6, "stocks,items");
             // TornData.TornStockInfo = Convert.ToString(JObject.Parse(TornData.TornJsonFetchedInfo));

          if (TornData.StocksIDandNames.ContainsKey("1") == false) // once information is feteched there is no need to update it as it stays constant.
          {
              MyFunctions.AddJsonDataToDictionary(TornData.StockIdandacronym, "stocks", "acronym", TornData.TornJsonFetchedInfo, 33);
              MyFunctions.AddJsonDataToDictionary(TornData.StocksIDandNames, "stocks", "name", TornData.TornJsonFetchedInfo, 33);
          }
          MyFunctions.AddJsonDataToDictionary(TornData.StockIDandCurrentPrice, "stocks", "current_price", TornData.TornJsonFetchedInfo, 33);
          MyFunctions.AddJsonDataToDictionary(TornData.StockIDandAvailableshares, "stocks", "available_shares", TornData.TornJsonFetchedInfo, 33);
          MyFunctions.AddJsonDataToDictionary(TornData.StockIdandForecast, "stocks", "forecast", TornData.TornJsonFetchedInfo, 33);
          MyFunctions.AddJsonDataToDictionary(TornData.StockIdandDemand, "stocks", "demand", TornData.TornJsonFetchedInfo, 33);
           
          }).Start();
          //  throw new Exception();


        }
        //FileReadToFromBrowseButton
        private void BrowseFileToReadAndSavebtn_Click(object sender, EventArgs e)
        {
            using (var FileReadToFromBrowseButton = new FolderBrowserDialog())
            {
                DialogResult result = FileReadToFromBrowseButton.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FileReadToFromBrowseButton.SelectedPath))
                {
                    string[] files = Directory.GetFiles(FileReadToFromBrowseButton.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                }
                FileToReadtoAndSaveTotxtbox.Text = FileReadToFromBrowseButton.SelectedPath;
                FileReadWriteLocations.FileToSaveItemList = FileToReadtoAndSaveTotxtbox.Text;
            }
            //FileToReadtoAndSaveTotxtbox.Text = FileReadToFromBrowseButton.SelectedPath;
          //  FileReadWriteLocations.FileToSaveItemList = FileToReadtoAndSaveTotxtbox.Text;
        }

        private void GetItemNamesAndIdbtn_Click(object sender, EventArgs e)
        {
            TornData.TornJsonFetchedInfo = MyFunctions.FetchUserData(6, "stocks,items");
            //TODO use code below to make json file

           //   TornData.TornItemInfo = Convert.ToString( JObject.Parse(Convert.ToString( File.ReadAllLines(FileReadWriteLocations.FileToSaveItemList + "\\ItemList"))));
            //  throw new Exception();

            //  This area was used to create a file containing all items and id's of them.
            //TODO Write feature to fetch item circulation and name by using the Files Name which fetchs ID then fetching circulation.
            try
            {
                if (File.Exists(FileReadWriteLocations.FileToSaveItemList + "\\ItemList") == false) // create file if it does not exsist
                {
                    MyFunctions.AddJsonDataToDictionary(TornData.ItemsIdAndName, "items", "name", TornData.TornJsonFetchedInfo, 1003);
                    List<string> itemlist = TornData.ItemsIdAndName.Keys.ToList();
                    List<string> itemlistname = TornData.ItemsIdAndName.Values.ToList();
                    int i = 0;

                    foreach (var item in TornData.ItemsIdAndName.Keys)
                    {
                        File.AppendAllText(FileReadWriteLocations.FileToSaveItemList + "\\ItemList", "\"" + itemlistname[i] + "\": { id:\"" + item + "\" } " + Environment.NewLine);
                        i++;
                    }
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("Have you Entered a Directory to Read From and Save to in Settings?");
               
            }
        }

        private void SettingsAPILockchkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsAPILockchkbox.Checked == true)
            {
                SettingsAPIKeyValuetxtbox.ReadOnly = true;
            }
            if (SettingsAPILockchkbox.Checked == false)
            {
                SettingsAPIKeyValuetxtbox.ReadOnly = false;
            }
        }
    }
}
