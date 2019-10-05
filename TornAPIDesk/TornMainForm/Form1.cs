using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

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
     public static string FetchUserData(int switchOption,string feilds) // function to request and receive API data.
            {
            string  test = null;
                switch (switchOption)
                {
                    case 1:
                         test = string.Format("https://api.torn.com/user/?selections=" + feilds + "&key=" + MainForm.APIKey);
                        break;
                    case 2: 
                         test = string.Format("https://api.torn.com/property/?selections=" + feilds + "&key=" + MainForm.APIKey);
                        break;
                    case 3:
                        test = test = string.Format("https://api.torn.com/faction/?selections=" + feilds + "&key=" + MainForm.APIKey);
                        break;
                    case 4:
                        test = string.Format("https://api.torn.com/company/?selections=" + feilds + "&key=" + MainForm.APIKey);
                        break;
                    case 5:
                         test = string.Format("https://api.torn.com/market/?selections=" + feilds + "&key=" + MainForm.APIKey);
                        break;
                    case 6:
                        test = test = string.Format("https://api.torn.com/torn/?selections=" + feilds + "&key=" + MainForm.APIKey);
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

             public  static void AddJsonDataToDictionary(Dictionary<string,string> DictToStore,string FromWhatParent,string TheChildYouWant) 
                 {

                string datacollected = MyFunctions.FetchUserData(6, FromWhatParent); // fetching api url data
                var readabledata = JObject.Parse(datacollected);
                var Id = JObject.Parse(Convert.ToString(readabledata));
                var f = JObject.Parse(Convert.ToString(Id[FromWhatParent]));
                
                for (int i = 0; i < 33; i++)
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


            } //failed func atm
        }

        public  class UserData
        {
             public static Dictionary<string, string> StocksIDandNames = new Dictionary<string, string> (); 
           
            public static string Basic = null; // value to become json string
            public  static JObject User = null; // contain feteched user data from json string
            public static  string level = null;
            public static string gender = null;
            public static string name = null;
            public static string player_id = null;
            public static string status = null;
            public static JToken Chainjson = null;
            public static JToken Lifejson = null;
            public static JToken Nervejson = null;
            public static JToken Energyjson = null;
            public static JToken Happyjson = null;
            public static JToken factionjson = null;
            public static JToken companyJson = null;
            public static JToken money = null;
            public static JToken DBMCooldowns = null;
            public static string TornTime = null;
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
                               
                ButtonLimittimer.Start();
                GetDatabtn.Enabled = false;
                
                OneSecondtimer.Start();
                GetDatabtn.Text = Convert.ToString(ButtonLimittimer.Interval / 1000);              

                UserData.Basic = MyFunctions.FetchUserData(1,"basic,profile,bars,money,cooldowns"); // Fields to fetch
                          
                UserData.User = JObject.Parse(UserData.Basic); // parse to fetchable jtoken data.
                var details = JObject.Parse(UserData.Basic); // makes json string data callable. 
                                                                          
                lvlValuelbl.Text = UserData.SetValue(UserData.Basic, UserData.level, "level");               
                GenderValuelbl.Text = UserData.SetValue(UserData.Basic, UserData.gender, "gender");
                NameValuelbl.Text = Convert.ToString(details["name"]);
                IDValuelbl.Text = Convert.ToString(details["player_id"]);
                UserData.TornTime = Convert.ToString(details["server_time"]);
                UserData.ChainCooldowns = Convert.ToString(details["cooldowns"]);

                string status = Convert.ToString(details["status"]).Trim(new char[] { '[', ']', ' ', ',', '"', '.' }).Replace("\"", string.Empty).Replace(",", string.Empty);
                
                Statuslbl.Text = "Status: " + status;
                UserData.Lifejson = details["life"];  LifeValue.Text = Convert.ToString(UserData.Lifejson["current"] + " / " + UserData.Lifejson["maximum"]);
                UserData.Energyjson = details["energy"]; EnergyValuelbl.Text = Convert.ToString(UserData.Energyjson["current"] + " / " + UserData.Energyjson["maximum"]);
                UserData.Nervejson = details["nerve"]; NerveValuelbl.Text = Convert.ToString(UserData.Nervejson["current"] + " / " + UserData.Nervejson["maximum"]);
                UserData.Happyjson = details["happy"]; HappyValuelbl.Text = Convert.ToString(UserData.Happyjson["current"] + " / " + UserData.Happyjson["maximum"]);
                UserData.Chainjson = details["chain"]; ChainValuelbl.Text = Convert.ToString(UserData.Chainjson["current"]);
                UserData.factionjson = details["faction"]; FactionValuelbl.Text = Convert.ToString(UserData.factionjson["faction_name"]);
                UserData.companyJson = details["job"]; CompanyValuelbl.Text = Convert.ToString(UserData.companyJson["company_name"]);
                PointsValuelbl.Text = "Points " + Convert.ToString(String.Format("{0:n0}", UserData.User["points"]));
                MoneyOnHandlbl.Text = "Money on hand: " + Convert.ToString(String.Format("{0:n0}", UserData.User["money_onhand"]));
                MoneyInVaultlbl.Text = "Money in Vault " + Convert.ToString(String.Format("{0:n0}", UserData.User["vault_amount"]));
                CoolDownValuelbl.Text = Convert.ToString(UserData.Chainjson["cooldown"]);
                UserData.DBMCooldowns = details["cooldowns"];                               

                ChainTimeOutValuelbl.Text =  Convert.ToString(UserData.Chainjson["timeout"]);                

                //   StatusValuelbl.Location.Y.Equals(StatusValuelbl.Location.Y - 40);                

                ApiKeyLockcbx.Checked = true;
                UserData.TimerAble += 1; // when timerable is > 0 the refreshtimer will automate itself. when an exception occurs value is put to 0 which turns timer off.

                int f = Refreshtimer.Interval / 1000; // value of refresh rate

                RefreshValuelbl.Text = Convert.ToString(f);
                OneSecondtimeTwo.Start(); // this timer should turn on last to prevent errors. the above code needs to run first.
                if (UserData.TimerAble > 0)
                {
                    Refreshtimer.Start();
                }
                
            }
            catch (Exception)
            {
               
                MessageBox.Show("Enter valid API key");
                OneSecondtimeTwo.Stop();
                UserData.TimerAble = 0; // when timerable is > 0 the refreshtimer will automate itself. when an exception occurs value is put to 0 which turns timer off.
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
              StatusLinkProfileValuelbl.Visible = true;               

            }
         
            RefreshValuelbl.Text = Convert.ToString( Convert.ToInt32(RefreshValuelbl.Text) -1); // decrease refresh value by 1 per timer tick which should be 1 second.

            try
            {                
                DateTime begginingoftime = new DateTime(1970, 01, 01);
                 
             var details = JObject.Parse(Convert.ToString(UserData.User));
                UserData.TornTime = Convert.ToString( Convert.ToInt64(UserData.TornTime) + 1);
                TimeSpan torntime = TimeSpan.FromSeconds(Convert.ToUInt64(UserData.TornTime) +1);
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

        private void StockGetDatabtn_Click(object sender, EventArgs e)
        {
            MyFunctions.AddJsonDataToDictionary(UserData.StocksIDandNames, "stocks","name");
        }
        ///////////////////////////////////////////////////Tab 2 Start////////////////////////////////////////////////////////////////





    }
}
