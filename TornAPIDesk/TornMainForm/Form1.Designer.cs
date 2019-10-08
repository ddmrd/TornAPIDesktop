namespace TornMainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TornAPIKey = new System.Windows.Forms.TextBox();
            this.APIkeylbl = new System.Windows.Forms.Label();
            this.ApiKeyLockcbx = new System.Windows.Forms.CheckBox();
            this.MainTabBar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewMessagesValuelbl = new System.Windows.Forms.Label();
            this.NewEventValuelbl = new System.Windows.Forms.Label();
            this.APILengthWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BankTimeLeftValuelbl = new System.Windows.Forms.Label();
            this.CityBankValuelbl = new System.Windows.Forms.Label();
            this.CaymanbankValuelbl = new System.Windows.Forms.Label();
            this.StatusLinkProfileValuelbl = new System.Windows.Forms.LinkLabel();
            this.BoosterCdValuelbl = new System.Windows.Forms.Label();
            this.BoosterCdlbl = new System.Windows.Forms.Label();
            this.MedicalCooldownValue = new System.Windows.Forms.Label();
            this.Medicallbl = new System.Windows.Forms.Label();
            this.DrugCdlbl = new System.Windows.Forms.Label();
            this.DrugCooldownValuelbl = new System.Windows.Forms.Label();
            this.HappyTickValuelbl = new System.Windows.Forms.Label();
            this.LifeTickValuelbl = new System.Windows.Forms.Label();
            this.NerveTimerValuelbl = new System.Windows.Forms.Label();
            this.EnergyIncrementlbl = new System.Windows.Forms.Label();
            this.CoolDownValuelbl = new System.Windows.Forms.Label();
            this.Cooldownlbl = new System.Windows.Forms.Label();
            this.MoneyInVaultlbl = new System.Windows.Forms.Label();
            this.MoneyOnHandlbl = new System.Windows.Forms.Label();
            this.PointsValuelbl = new System.Windows.Forms.Label();
            this.ChainTimeOutValuelbl = new System.Windows.Forms.Label();
            this.ChainTimeoutlbl = new System.Windows.Forms.Label();
            this.refreshlbll = new System.Windows.Forms.Label();
            this.RefreshValuelbl = new System.Windows.Forms.Label();
            this.VisitTornlbl = new System.Windows.Forms.LinkLabel();
            this.ChainValuelbl = new System.Windows.Forms.Label();
            this.Chainlbl = new System.Windows.Forms.Label();
            this.HappyValuelbl = new System.Windows.Forms.Label();
            this.Happylbl = new System.Windows.Forms.Label();
            this.NerveValuelbl = new System.Windows.Forms.Label();
            this.Nervelbl = new System.Windows.Forms.Label();
            this.EnergyValuelbl = new System.Windows.Forms.Label();
            this.Energylbl = new System.Windows.Forms.Label();
            this.LifeValue = new System.Windows.Forms.Label();
            this.Hplbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.IDValuelbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.NameValuelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.GenderValuelbl = new System.Windows.Forms.Label();
            this.genderlbl = new System.Windows.Forms.Label();
            this.lvlValuelbl = new System.Windows.Forms.Label();
            this.lvllbl = new System.Windows.Forms.Label();
            this.GetDatabtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GetItemNamesAndIdbtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.StockGetDatabtn = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveSettingsbtn = new System.Windows.Forms.Button();
            this.SettingsDescriptionlbl = new System.Windows.Forms.Label();
            this.SettingsAPIkeylbl = new System.Windows.Forms.Label();
            this.SettingsAPILockchkbox = new System.Windows.Forms.CheckBox();
            this.SettingsAPIKeyValuetxtbox = new System.Windows.Forms.TextBox();
            this.BrowseFileToReadAndSavebtn = new System.Windows.Forms.Button();
            this.FileToReadtoAndSaveTotxtbox = new System.Windows.Forms.TextBox();
            this.FileToSaveAndReadItemNameAndId = new System.Windows.Forms.Label();
            this.Refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonLimittimer = new System.Windows.Forms.Timer(this.components);
            this.OneSecondtimer = new System.Windows.Forms.Timer(this.components);
            this.OneSecondtimeTwo = new System.Windows.Forms.Timer(this.components);
            this.TornCityTimelbl = new System.Windows.Forms.Label();
            this.MainTabBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TornAPIKey
            // 
            this.TornAPIKey.Location = new System.Drawing.Point(79, 15);
            this.TornAPIKey.MaxLength = 16;
            this.TornAPIKey.Name = "TornAPIKey";
            this.TornAPIKey.Size = new System.Drawing.Size(362, 20);
            this.TornAPIKey.TabIndex = 0;
            this.TornAPIKey.TextChanged += new System.EventHandler(this.TornAPIKey_TextChanged);
            // 
            // APIkeylbl
            // 
            this.APIkeylbl.AutoSize = true;
            this.APIkeylbl.Location = new System.Drawing.Point(4, 18);
            this.APIkeylbl.Name = "APIkeylbl";
            this.APIkeylbl.Size = new System.Drawing.Size(69, 13);
            this.APIkeylbl.TabIndex = 1;
            this.APIkeylbl.Text = "Your API key";
            // 
            // ApiKeyLockcbx
            // 
            this.ApiKeyLockcbx.AutoSize = true;
            this.ApiKeyLockcbx.Location = new System.Drawing.Point(447, 18);
            this.ApiKeyLockcbx.Name = "ApiKeyLockcbx";
            this.ApiKeyLockcbx.Size = new System.Drawing.Size(70, 17);
            this.ApiKeyLockcbx.TabIndex = 2;
            this.ApiKeyLockcbx.Text = "Lock text";
            this.ApiKeyLockcbx.UseVisualStyleBackColor = true;
            this.ApiKeyLockcbx.CheckedChanged += new System.EventHandler(this.ApiKeyLockcbx_CheckedChanged);
            // 
            // MainTabBar
            // 
            this.MainTabBar.Controls.Add(this.tabPage1);
            this.MainTabBar.Controls.Add(this.tabPage2);
            this.MainTabBar.Controls.Add(this.tabPage3);
            this.MainTabBar.Controls.Add(this.tabPage4);
            this.MainTabBar.Controls.Add(this.tabPage5);
            this.MainTabBar.Location = new System.Drawing.Point(12, 12);
            this.MainTabBar.Name = "MainTabBar";
            this.MainTabBar.SelectedIndex = 0;
            this.MainTabBar.Size = new System.Drawing.Size(545, 337);
            this.MainTabBar.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.NewMessagesValuelbl);
            this.tabPage1.Controls.Add(this.NewEventValuelbl);
            this.tabPage1.Controls.Add(this.APILengthWarning);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BankTimeLeftValuelbl);
            this.tabPage1.Controls.Add(this.CityBankValuelbl);
            this.tabPage1.Controls.Add(this.CaymanbankValuelbl);
            this.tabPage1.Controls.Add(this.StatusLinkProfileValuelbl);
            this.tabPage1.Controls.Add(this.BoosterCdValuelbl);
            this.tabPage1.Controls.Add(this.BoosterCdlbl);
            this.tabPage1.Controls.Add(this.MedicalCooldownValue);
            this.tabPage1.Controls.Add(this.Medicallbl);
            this.tabPage1.Controls.Add(this.DrugCdlbl);
            this.tabPage1.Controls.Add(this.DrugCooldownValuelbl);
            this.tabPage1.Controls.Add(this.HappyTickValuelbl);
            this.tabPage1.Controls.Add(this.LifeTickValuelbl);
            this.tabPage1.Controls.Add(this.NerveTimerValuelbl);
            this.tabPage1.Controls.Add(this.EnergyIncrementlbl);
            this.tabPage1.Controls.Add(this.CoolDownValuelbl);
            this.tabPage1.Controls.Add(this.Cooldownlbl);
            this.tabPage1.Controls.Add(this.MoneyInVaultlbl);
            this.tabPage1.Controls.Add(this.MoneyOnHandlbl);
            this.tabPage1.Controls.Add(this.PointsValuelbl);
            this.tabPage1.Controls.Add(this.ChainTimeOutValuelbl);
            this.tabPage1.Controls.Add(this.ChainTimeoutlbl);
            this.tabPage1.Controls.Add(this.refreshlbll);
            this.tabPage1.Controls.Add(this.RefreshValuelbl);
            this.tabPage1.Controls.Add(this.VisitTornlbl);
            this.tabPage1.Controls.Add(this.ChainValuelbl);
            this.tabPage1.Controls.Add(this.Chainlbl);
            this.tabPage1.Controls.Add(this.HappyValuelbl);
            this.tabPage1.Controls.Add(this.Happylbl);
            this.tabPage1.Controls.Add(this.NerveValuelbl);
            this.tabPage1.Controls.Add(this.Nervelbl);
            this.tabPage1.Controls.Add(this.EnergyValuelbl);
            this.tabPage1.Controls.Add(this.Energylbl);
            this.tabPage1.Controls.Add(this.LifeValue);
            this.tabPage1.Controls.Add(this.Hplbl);
            this.tabPage1.Controls.Add(this.Statuslbl);
            this.tabPage1.Controls.Add(this.IDValuelbl);
            this.tabPage1.Controls.Add(this.idlbl);
            this.tabPage1.Controls.Add(this.NameValuelbl);
            this.tabPage1.Controls.Add(this.Namelbl);
            this.tabPage1.Controls.Add(this.GenderValuelbl);
            this.tabPage1.Controls.Add(this.genderlbl);
            this.tabPage1.Controls.Add(this.lvlValuelbl);
            this.tabPage1.Controls.Add(this.lvllbl);
            this.tabPage1.Controls.Add(this.GetDatabtn);
            this.tabPage1.Controls.Add(this.APIkeylbl);
            this.tabPage1.Controls.Add(this.ApiKeyLockcbx);
            this.tabPage1.Controls.Add(this.TornAPIKey);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UserInfo";
            // 
            // NewMessagesValuelbl
            // 
            this.NewMessagesValuelbl.AutoSize = true;
            this.NewMessagesValuelbl.Location = new System.Drawing.Point(87, 288);
            this.NewMessagesValuelbl.Name = "NewMessagesValuelbl";
            this.NewMessagesValuelbl.Size = new System.Drawing.Size(80, 13);
            this.NewMessagesValuelbl.TabIndex = 57;
            this.NewMessagesValuelbl.Text = "New Messages";
            // 
            // NewEventValuelbl
            // 
            this.NewEventValuelbl.AutoSize = true;
            this.NewEventValuelbl.Location = new System.Drawing.Point(198, 287);
            this.NewEventValuelbl.Name = "NewEventValuelbl";
            this.NewEventValuelbl.Size = new System.Drawing.Size(71, 13);
            this.NewEventValuelbl.TabIndex = 56;
            this.NewEventValuelbl.Text = "New Events: ";
            // 
            // APILengthWarning
            // 
            this.APILengthWarning.AutoSize = true;
            this.APILengthWarning.ForeColor = System.Drawing.Color.Red;
            this.APILengthWarning.Location = new System.Drawing.Point(79, 42);
            this.APILengthWarning.Name = "APILengthWarning";
            this.APILengthWarning.Size = new System.Drawing.Size(184, 13);
            this.APILengthWarning.TabIndex = 55;
            this.APILengthWarning.Text = "API key should be 16 characters long";
            this.APILengthWarning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Bank Time left: ";
            // 
            // BankTimeLeftValuelbl
            // 
            this.BankTimeLeftValuelbl.AutoSize = true;
            this.BankTimeLeftValuelbl.Location = new System.Drawing.Point(427, 250);
            this.BankTimeLeftValuelbl.Name = "BankTimeLeftValuelbl";
            this.BankTimeLeftValuelbl.Size = new System.Drawing.Size(26, 13);
            this.BankTimeLeftValuelbl.TabIndex = 53;
            this.BankTimeLeftValuelbl.Text = "N/a";
            // 
            // CityBankValuelbl
            // 
            this.CityBankValuelbl.AutoSize = true;
            this.CityBankValuelbl.Location = new System.Drawing.Point(337, 220);
            this.CityBankValuelbl.Name = "CityBankValuelbl";
            this.CityBankValuelbl.Size = new System.Drawing.Size(52, 13);
            this.CityBankValuelbl.TabIndex = 52;
            this.CityBankValuelbl.Text = "City Bank";
            // 
            // CaymanbankValuelbl
            // 
            this.CaymanbankValuelbl.AutoSize = true;
            this.CaymanbankValuelbl.Location = new System.Drawing.Point(337, 190);
            this.CaymanbankValuelbl.Name = "CaymanbankValuelbl";
            this.CaymanbankValuelbl.Size = new System.Drawing.Size(72, 13);
            this.CaymanbankValuelbl.TabIndex = 51;
            this.CaymanbankValuelbl.Text = "Cayman bank";
            // 
            // StatusLinkProfileValuelbl
            // 
            this.StatusLinkProfileValuelbl.AutoSize = true;
            this.StatusLinkProfileValuelbl.LinkColor = System.Drawing.Color.Blue;
            this.StatusLinkProfileValuelbl.Location = new System.Drawing.Point(398, 82);
            this.StatusLinkProfileValuelbl.Name = "StatusLinkProfileValuelbl";
            this.StatusLinkProfileValuelbl.Size = new System.Drawing.Size(55, 13);
            this.StatusLinkProfileValuelbl.TabIndex = 50;
            this.StatusLinkProfileValuelbl.TabStop = true;
            this.StatusLinkProfileValuelbl.Text = "linkLabel1";
            this.StatusLinkProfileValuelbl.Visible = false;
            this.StatusLinkProfileValuelbl.VisitedLinkColor = System.Drawing.Color.Blue;
            this.StatusLinkProfileValuelbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StatusLinkProfileValuelbl_LinkClicked);
            // 
            // BoosterCdValuelbl
            // 
            this.BoosterCdValuelbl.AutoSize = true;
            this.BoosterCdValuelbl.Location = new System.Drawing.Point(264, 198);
            this.BoosterCdValuelbl.Name = "BoosterCdValuelbl";
            this.BoosterCdValuelbl.Size = new System.Drawing.Size(24, 13);
            this.BoosterCdValuelbl.TabIndex = 49;
            this.BoosterCdValuelbl.Text = "n/a";
            // 
            // BoosterCdlbl
            // 
            this.BoosterCdlbl.AutoSize = true;
            this.BoosterCdlbl.Location = new System.Drawing.Point(193, 198);
            this.BoosterCdlbl.Name = "BoosterCdlbl";
            this.BoosterCdlbl.Size = new System.Drawing.Size(64, 13);
            this.BoosterCdlbl.TabIndex = 48;
            this.BoosterCdlbl.Text = "Booster CD:";
            // 
            // MedicalCooldownValue
            // 
            this.MedicalCooldownValue.AutoSize = true;
            this.MedicalCooldownValue.Location = new System.Drawing.Point(264, 168);
            this.MedicalCooldownValue.Name = "MedicalCooldownValue";
            this.MedicalCooldownValue.Size = new System.Drawing.Size(24, 13);
            this.MedicalCooldownValue.TabIndex = 47;
            this.MedicalCooldownValue.Text = "n/a";
            // 
            // Medicallbl
            // 
            this.Medicallbl.AutoSize = true;
            this.Medicallbl.Location = new System.Drawing.Point(193, 168);
            this.Medicallbl.Name = "Medicallbl";
            this.Medicallbl.Size = new System.Drawing.Size(65, 13);
            this.Medicallbl.TabIndex = 46;
            this.Medicallbl.Text = "Medical CD:";
            // 
            // DrugCdlbl
            // 
            this.DrugCdlbl.AutoSize = true;
            this.DrugCdlbl.Location = new System.Drawing.Point(193, 138);
            this.DrugCdlbl.Name = "DrugCdlbl";
            this.DrugCdlbl.Size = new System.Drawing.Size(51, 13);
            this.DrugCdlbl.TabIndex = 45;
            this.DrugCdlbl.Text = "Drug CD:";
            // 
            // DrugCooldownValuelbl
            // 
            this.DrugCooldownValuelbl.AutoSize = true;
            this.DrugCooldownValuelbl.Location = new System.Drawing.Point(264, 138);
            this.DrugCooldownValuelbl.Name = "DrugCooldownValuelbl";
            this.DrugCooldownValuelbl.Size = new System.Drawing.Size(24, 13);
            this.DrugCooldownValuelbl.TabIndex = 44;
            this.DrugCooldownValuelbl.Text = "n/a";
            // 
            // HappyTickValuelbl
            // 
            this.HappyTickValuelbl.AutoSize = true;
            this.HappyTickValuelbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.HappyTickValuelbl.Location = new System.Drawing.Point(125, 198);
            this.HappyTickValuelbl.Name = "HappyTickValuelbl";
            this.HappyTickValuelbl.Size = new System.Drawing.Size(26, 13);
            this.HappyTickValuelbl.TabIndex = 43;
            this.HappyTickValuelbl.Text = "N/a";
            // 
            // LifeTickValuelbl
            // 
            this.LifeTickValuelbl.AutoSize = true;
            this.LifeTickValuelbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LifeTickValuelbl.Location = new System.Drawing.Point(125, 228);
            this.LifeTickValuelbl.Name = "LifeTickValuelbl";
            this.LifeTickValuelbl.Size = new System.Drawing.Size(26, 13);
            this.LifeTickValuelbl.TabIndex = 42;
            this.LifeTickValuelbl.Text = "N/a";
            // 
            // NerveTimerValuelbl
            // 
            this.NerveTimerValuelbl.AutoSize = true;
            this.NerveTimerValuelbl.ForeColor = System.Drawing.Color.Red;
            this.NerveTimerValuelbl.Location = new System.Drawing.Point(125, 168);
            this.NerveTimerValuelbl.Name = "NerveTimerValuelbl";
            this.NerveTimerValuelbl.Size = new System.Drawing.Size(26, 13);
            this.NerveTimerValuelbl.TabIndex = 41;
            this.NerveTimerValuelbl.Text = "N/a";
            // 
            // EnergyIncrementlbl
            // 
            this.EnergyIncrementlbl.AutoSize = true;
            this.EnergyIncrementlbl.ForeColor = System.Drawing.Color.Green;
            this.EnergyIncrementlbl.Location = new System.Drawing.Point(125, 138);
            this.EnergyIncrementlbl.Name = "EnergyIncrementlbl";
            this.EnergyIncrementlbl.Size = new System.Drawing.Size(26, 13);
            this.EnergyIncrementlbl.TabIndex = 40;
            this.EnergyIncrementlbl.Text = "N/a";
            // 
            // CoolDownValuelbl
            // 
            this.CoolDownValuelbl.AutoSize = true;
            this.CoolDownValuelbl.Location = new System.Drawing.Point(264, 257);
            this.CoolDownValuelbl.Name = "CoolDownValuelbl";
            this.CoolDownValuelbl.Size = new System.Drawing.Size(13, 13);
            this.CoolDownValuelbl.TabIndex = 39;
            this.CoolDownValuelbl.Text = "0";
            // 
            // Cooldownlbl
            // 
            this.Cooldownlbl.AutoSize = true;
            this.Cooldownlbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Cooldownlbl.Location = new System.Drawing.Point(198, 257);
            this.Cooldownlbl.Name = "Cooldownlbl";
            this.Cooldownlbl.Size = new System.Drawing.Size(60, 13);
            this.Cooldownlbl.TabIndex = 38;
            this.Cooldownlbl.Text = "Cooldown: ";
            // 
            // MoneyInVaultlbl
            // 
            this.MoneyInVaultlbl.AutoSize = true;
            this.MoneyInVaultlbl.Location = new System.Drawing.Point(337, 160);
            this.MoneyInVaultlbl.Name = "MoneyInVaultlbl";
            this.MoneyInVaultlbl.Size = new System.Drawing.Size(77, 13);
            this.MoneyInVaultlbl.TabIndex = 37;
            this.MoneyInVaultlbl.Text = "Money in Vault";
            // 
            // MoneyOnHandlbl
            // 
            this.MoneyOnHandlbl.AutoSize = true;
            this.MoneyOnHandlbl.Location = new System.Drawing.Point(337, 130);
            this.MoneyOnHandlbl.Name = "MoneyOnHandlbl";
            this.MoneyOnHandlbl.Size = new System.Drawing.Size(84, 13);
            this.MoneyOnHandlbl.TabIndex = 36;
            this.MoneyOnHandlbl.Text = "Money on hand ";
            // 
            // PointsValuelbl
            // 
            this.PointsValuelbl.AutoSize = true;
            this.PointsValuelbl.Location = new System.Drawing.Point(337, 102);
            this.PointsValuelbl.Name = "PointsValuelbl";
            this.PointsValuelbl.Size = new System.Drawing.Size(39, 13);
            this.PointsValuelbl.TabIndex = 35;
            this.PointsValuelbl.Text = "Points:";
            // 
            // ChainTimeOutValuelbl
            // 
            this.ChainTimeOutValuelbl.AutoSize = true;
            this.ChainTimeOutValuelbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ChainTimeOutValuelbl.Location = new System.Drawing.Point(157, 257);
            this.ChainTimeOutValuelbl.Name = "ChainTimeOutValuelbl";
            this.ChainTimeOutValuelbl.Size = new System.Drawing.Size(13, 13);
            this.ChainTimeOutValuelbl.TabIndex = 33;
            this.ChainTimeOutValuelbl.Text = "0";
            // 
            // ChainTimeoutlbl
            // 
            this.ChainTimeoutlbl.AutoSize = true;
            this.ChainTimeoutlbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ChainTimeoutlbl.Location = new System.Drawing.Point(87, 258);
            this.ChainTimeoutlbl.Name = "ChainTimeoutlbl";
            this.ChainTimeoutlbl.Size = new System.Drawing.Size(64, 13);
            this.ChainTimeoutlbl.TabIndex = 32;
            this.ChainTimeoutlbl.Text = "TimeOut in: ";
            // 
            // refreshlbll
            // 
            this.refreshlbll.AutoSize = true;
            this.refreshlbll.Location = new System.Drawing.Point(337, 287);
            this.refreshlbll.Name = "refreshlbll";
            this.refreshlbll.Size = new System.Drawing.Size(55, 13);
            this.refreshlbll.TabIndex = 31;
            this.refreshlbll.Text = "Refresh in";
            // 
            // RefreshValuelbl
            // 
            this.RefreshValuelbl.AutoSize = true;
            this.RefreshValuelbl.Location = new System.Drawing.Point(398, 288);
            this.RefreshValuelbl.Name = "RefreshValuelbl";
            this.RefreshValuelbl.Size = new System.Drawing.Size(13, 13);
            this.RefreshValuelbl.TabIndex = 30;
            this.RefreshValuelbl.Text = "0";
            // 
            // VisitTornlbl
            // 
            this.VisitTornlbl.AutoSize = true;
            this.VisitTornlbl.LinkColor = System.Drawing.Color.Blue;
            this.VisitTornlbl.Location = new System.Drawing.Point(18, 287);
            this.VisitTornlbl.Name = "VisitTornlbl";
            this.VisitTornlbl.Size = new System.Drawing.Size(48, 13);
            this.VisitTornlbl.TabIndex = 29;
            this.VisitTornlbl.TabStop = true;
            this.VisitTornlbl.Text = "VisitTorn";
            this.VisitTornlbl.VisitedLinkColor = System.Drawing.Color.Blue;
            this.VisitTornlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VisitTornlbl_LinkClicked);
            // 
            // ChainValuelbl
            // 
            this.ChainValuelbl.AutoSize = true;
            this.ChainValuelbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChainValuelbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ChainValuelbl.Location = new System.Drawing.Point(50, 258);
            this.ChainValuelbl.Name = "ChainValuelbl";
            this.ChainValuelbl.Size = new System.Drawing.Size(30, 16);
            this.ChainValuelbl.TabIndex = 24;
            this.ChainValuelbl.Text = "N/A";
            // 
            // Chainlbl
            // 
            this.Chainlbl.AutoSize = true;
            this.Chainlbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chainlbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Chainlbl.Location = new System.Drawing.Point(6, 258);
            this.Chainlbl.Name = "Chainlbl";
            this.Chainlbl.Size = new System.Drawing.Size(41, 16);
            this.Chainlbl.TabIndex = 23;
            this.Chainlbl.Text = "Chain:";
            // 
            // HappyValuelbl
            // 
            this.HappyValuelbl.AutoSize = true;
            this.HappyValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HappyValuelbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.HappyValuelbl.Location = new System.Drawing.Point(50, 198);
            this.HappyValuelbl.Name = "HappyValuelbl";
            this.HappyValuelbl.Size = new System.Drawing.Size(30, 13);
            this.HappyValuelbl.TabIndex = 22;
            this.HappyValuelbl.Text = "N/A";
            // 
            // Happylbl
            // 
            this.Happylbl.AutoSize = true;
            this.Happylbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Happylbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Happylbl.Location = new System.Drawing.Point(6, 198);
            this.Happylbl.Name = "Happylbl";
            this.Happylbl.Size = new System.Drawing.Size(46, 16);
            this.Happylbl.TabIndex = 21;
            this.Happylbl.Text = "Happy:";
            // 
            // NerveValuelbl
            // 
            this.NerveValuelbl.AutoSize = true;
            this.NerveValuelbl.BackColor = System.Drawing.Color.White;
            this.NerveValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NerveValuelbl.ForeColor = System.Drawing.Color.Red;
            this.NerveValuelbl.Location = new System.Drawing.Point(50, 168);
            this.NerveValuelbl.Name = "NerveValuelbl";
            this.NerveValuelbl.Size = new System.Drawing.Size(30, 13);
            this.NerveValuelbl.TabIndex = 20;
            this.NerveValuelbl.Text = "N/A";
            // 
            // Nervelbl
            // 
            this.Nervelbl.AutoSize = true;
            this.Nervelbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nervelbl.ForeColor = System.Drawing.Color.Red;
            this.Nervelbl.Location = new System.Drawing.Point(6, 168);
            this.Nervelbl.Name = "Nervelbl";
            this.Nervelbl.Size = new System.Drawing.Size(46, 16);
            this.Nervelbl.TabIndex = 19;
            this.Nervelbl.Text = "Nerve: ";
            // 
            // EnergyValuelbl
            // 
            this.EnergyValuelbl.AutoSize = true;
            this.EnergyValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyValuelbl.ForeColor = System.Drawing.Color.Green;
            this.EnergyValuelbl.Location = new System.Drawing.Point(50, 138);
            this.EnergyValuelbl.Name = "EnergyValuelbl";
            this.EnergyValuelbl.Size = new System.Drawing.Size(30, 13);
            this.EnergyValuelbl.TabIndex = 18;
            this.EnergyValuelbl.Text = "N/A";
            // 
            // Energylbl
            // 
            this.Energylbl.AutoSize = true;
            this.Energylbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Energylbl.ForeColor = System.Drawing.Color.Green;
            this.Energylbl.Location = new System.Drawing.Point(6, 138);
            this.Energylbl.Name = "Energylbl";
            this.Energylbl.Size = new System.Drawing.Size(51, 16);
            this.Energylbl.TabIndex = 17;
            this.Energylbl.Text = "Energy: ";
            // 
            // LifeValue
            // 
            this.LifeValue.AutoSize = true;
            this.LifeValue.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LifeValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LifeValue.Location = new System.Drawing.Point(50, 228);
            this.LifeValue.Name = "LifeValue";
            this.LifeValue.Size = new System.Drawing.Size(30, 16);
            this.LifeValue.TabIndex = 16;
            this.LifeValue.Text = "N/A";
            // 
            // Hplbl
            // 
            this.Hplbl.AutoSize = true;
            this.Hplbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hplbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Hplbl.Location = new System.Drawing.Point(6, 228);
            this.Hplbl.Name = "Hplbl";
            this.Hplbl.Size = new System.Drawing.Size(30, 16);
            this.Hplbl.TabIndex = 15;
            this.Hplbl.Text = "Life:";
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.Location = new System.Drawing.Point(316, 51);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(51, 16);
            this.Statuslbl.TabIndex = 13;
            this.Statuslbl.Text = "Status: ";
            // 
            // IDValuelbl
            // 
            this.IDValuelbl.AutoSize = true;
            this.IDValuelbl.Location = new System.Drawing.Point(198, 54);
            this.IDValuelbl.Name = "IDValuelbl";
            this.IDValuelbl.Size = new System.Drawing.Size(27, 13);
            this.IDValuelbl.TabIndex = 12;
            this.IDValuelbl.Text = "N/A";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(171, 54);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(21, 13);
            this.idlbl.TabIndex = 11;
            this.idlbl.Text = "ID:";
            // 
            // NameValuelbl
            // 
            this.NameValuelbl.AutoSize = true;
            this.NameValuelbl.Location = new System.Drawing.Point(47, 55);
            this.NameValuelbl.Name = "NameValuelbl";
            this.NameValuelbl.Size = new System.Drawing.Size(27, 13);
            this.NameValuelbl.TabIndex = 10;
            this.NameValuelbl.Text = "N/A";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(3, 55);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(41, 13);
            this.Namelbl.TabIndex = 9;
            this.Namelbl.Text = "Name: ";
            // 
            // GenderValuelbl
            // 
            this.GenderValuelbl.AutoSize = true;
            this.GenderValuelbl.Location = new System.Drawing.Point(225, 79);
            this.GenderValuelbl.Name = "GenderValuelbl";
            this.GenderValuelbl.Size = new System.Drawing.Size(27, 13);
            this.GenderValuelbl.TabIndex = 8;
            this.GenderValuelbl.Text = "N/A";
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Location = new System.Drawing.Point(171, 79);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(48, 13);
            this.genderlbl.TabIndex = 7;
            this.genderlbl.Text = "Gender: ";
            // 
            // lvlValuelbl
            // 
            this.lvlValuelbl.AutoSize = true;
            this.lvlValuelbl.Location = new System.Drawing.Point(48, 79);
            this.lvlValuelbl.Name = "lvlValuelbl";
            this.lvlValuelbl.Size = new System.Drawing.Size(27, 13);
            this.lvlValuelbl.TabIndex = 6;
            this.lvlValuelbl.Text = "N/A";
            // 
            // lvllbl
            // 
            this.lvllbl.AutoSize = true;
            this.lvllbl.Location = new System.Drawing.Point(3, 79);
            this.lvllbl.Name = "lvllbl";
            this.lvllbl.Size = new System.Drawing.Size(39, 13);
            this.lvllbl.TabIndex = 5;
            this.lvllbl.Text = "Level: ";
            // 
            // GetDatabtn
            // 
            this.GetDatabtn.Location = new System.Drawing.Point(442, 282);
            this.GetDatabtn.Name = "GetDatabtn";
            this.GetDatabtn.Size = new System.Drawing.Size(75, 23);
            this.GetDatabtn.TabIndex = 4;
            this.GetDatabtn.Text = "GetData";
            this.GetDatabtn.UseVisualStyleBackColor = true;
            this.GetDatabtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GetItemNamesAndIdbtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(537, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ItemSearch";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GetItemNamesAndIdbtn
            // 
            this.GetItemNamesAndIdbtn.Location = new System.Drawing.Point(456, 282);
            this.GetItemNamesAndIdbtn.Name = "GetItemNamesAndIdbtn";
            this.GetItemNamesAndIdbtn.Size = new System.Drawing.Size(75, 23);
            this.GetItemNamesAndIdbtn.TabIndex = 0;
            this.GetItemNamesAndIdbtn.Text = "Fetch Item";
            this.GetItemNamesAndIdbtn.UseVisualStyleBackColor = true;
            this.GetItemNamesAndIdbtn.Click += new System.EventHandler(this.GetItemNamesAndIdbtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.StockGetDatabtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(537, 311);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // StockGetDatabtn
            // 
            this.StockGetDatabtn.Location = new System.Drawing.Point(439, 282);
            this.StockGetDatabtn.Name = "StockGetDatabtn";
            this.StockGetDatabtn.Size = new System.Drawing.Size(92, 23);
            this.StockGetDatabtn.TabIndex = 0;
            this.StockGetDatabtn.Text = "Get Stock Info";
            this.StockGetDatabtn.UseVisualStyleBackColor = true;
            this.StockGetDatabtn.Click += new System.EventHandler(this.StockGetDatabtn_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox1);
            this.tabPage5.Controls.Add(this.SaveSettingsbtn);
            this.tabPage5.Controls.Add(this.SettingsDescriptionlbl);
            this.tabPage5.Controls.Add(this.SettingsAPIkeylbl);
            this.tabPage5.Controls.Add(this.SettingsAPILockchkbox);
            this.tabPage5.Controls.Add(this.SettingsAPIKeyValuetxtbox);
            this.tabPage5.Controls.Add(this.BrowseFileToReadAndSavebtn);
            this.tabPage5.Controls.Add(this.FileToReadtoAndSaveTotxtbox);
            this.tabPage5.Controls.Add(this.FileToSaveAndReadItemNameAndId);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(537, 311);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(91, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SaveSettingsbtn
            // 
            this.SaveSettingsbtn.Location = new System.Drawing.Point(226, 282);
            this.SaveSettingsbtn.Name = "SaveSettingsbtn";
            this.SaveSettingsbtn.Size = new System.Drawing.Size(112, 23);
            this.SaveSettingsbtn.TabIndex = 7;
            this.SaveSettingsbtn.Text = "Save Settings";
            this.SaveSettingsbtn.UseVisualStyleBackColor = true;
            this.SaveSettingsbtn.Click += new System.EventHandler(this.SaveSettingsbtn_Click);
            // 
            // SettingsDescriptionlbl
            // 
            this.SettingsDescriptionlbl.Location = new System.Drawing.Point(22, 26);
            this.SettingsDescriptionlbl.Name = "SettingsDescriptionlbl";
            this.SettingsDescriptionlbl.Size = new System.Drawing.Size(474, 60);
            this.SettingsDescriptionlbl.TabIndex = 6;
            this.SettingsDescriptionlbl.Text = resources.GetString("SettingsDescriptionlbl.Text");
            // 
            // SettingsAPIkeylbl
            // 
            this.SettingsAPIkeylbl.AutoSize = true;
            this.SettingsAPIkeylbl.Location = new System.Drawing.Point(6, 159);
            this.SettingsAPIkeylbl.Name = "SettingsAPIkeylbl";
            this.SettingsAPIkeylbl.Size = new System.Drawing.Size(69, 13);
            this.SettingsAPIkeylbl.TabIndex = 4;
            this.SettingsAPIkeylbl.Text = "Your API key";
            // 
            // SettingsAPILockchkbox
            // 
            this.SettingsAPILockchkbox.AutoSize = true;
            this.SettingsAPILockchkbox.Checked = true;
            this.SettingsAPILockchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SettingsAPILockchkbox.Location = new System.Drawing.Point(449, 159);
            this.SettingsAPILockchkbox.Name = "SettingsAPILockchkbox";
            this.SettingsAPILockchkbox.Size = new System.Drawing.Size(70, 17);
            this.SettingsAPILockchkbox.TabIndex = 5;
            this.SettingsAPILockchkbox.Text = "Lock text";
            this.SettingsAPILockchkbox.UseVisualStyleBackColor = true;
            this.SettingsAPILockchkbox.CheckedChanged += new System.EventHandler(this.SettingsAPILockchkbox_CheckedChanged);
            // 
            // SettingsAPIKeyValuetxtbox
            // 
            this.SettingsAPIKeyValuetxtbox.Location = new System.Drawing.Point(81, 156);
            this.SettingsAPIKeyValuetxtbox.MaxLength = 16;
            this.SettingsAPIKeyValuetxtbox.Name = "SettingsAPIKeyValuetxtbox";
            this.SettingsAPIKeyValuetxtbox.Size = new System.Drawing.Size(362, 20);
            this.SettingsAPIKeyValuetxtbox.TabIndex = 3;
            // 
            // BrowseFileToReadAndSavebtn
            // 
            this.BrowseFileToReadAndSavebtn.Location = new System.Drawing.Point(430, 105);
            this.BrowseFileToReadAndSavebtn.Name = "BrowseFileToReadAndSavebtn";
            this.BrowseFileToReadAndSavebtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseFileToReadAndSavebtn.TabIndex = 2;
            this.BrowseFileToReadAndSavebtn.Text = "Browse";
            this.BrowseFileToReadAndSavebtn.UseVisualStyleBackColor = true;
            this.BrowseFileToReadAndSavebtn.Click += new System.EventHandler(this.BrowseFileToReadAndSavebtn_Click);
            // 
            // FileToReadtoAndSaveTotxtbox
            // 
            this.FileToReadtoAndSaveTotxtbox.Location = new System.Drawing.Point(177, 105);
            this.FileToReadtoAndSaveTotxtbox.Name = "FileToReadtoAndSaveTotxtbox";
            this.FileToReadtoAndSaveTotxtbox.ReadOnly = true;
            this.FileToReadtoAndSaveTotxtbox.Size = new System.Drawing.Size(236, 20);
            this.FileToReadtoAndSaveTotxtbox.TabIndex = 1;
            // 
            // FileToSaveAndReadItemNameAndId
            // 
            this.FileToSaveAndReadItemNameAndId.AutoSize = true;
            this.FileToSaveAndReadItemNameAndId.Location = new System.Drawing.Point(5, 108);
            this.FileToSaveAndReadItemNameAndId.Name = "FileToSaveAndReadItemNameAndId";
            this.FileToSaveAndReadItemNameAndId.Size = new System.Drawing.Size(166, 13);
            this.FileToSaveAndReadItemNameAndId.TabIndex = 0;
            this.FileToSaveAndReadItemNameAndId.Text = "File location to save and load files";
            // 
            // Refreshtimer
            // 
            this.Refreshtimer.Interval = 30000;
            this.Refreshtimer.Tick += new System.EventHandler(this.Refreshtimer_Tick);
            // 
            // ButtonLimittimer
            // 
            this.ButtonLimittimer.Interval = 12000;
            this.ButtonLimittimer.Tick += new System.EventHandler(this.ButtonLimittimer_Tick);
            // 
            // OneSecondtimer
            // 
            this.OneSecondtimer.Interval = 1000;
            this.OneSecondtimer.Tick += new System.EventHandler(this.OneSecondtimer_Tick);
            // 
            // OneSecondtimeTwo
            // 
            this.OneSecondtimeTwo.Interval = 1000;
            this.OneSecondtimeTwo.Tick += new System.EventHandler(this.OneSecondtimeTwo_Tick);
            // 
            // TornCityTimelbl
            // 
            this.TornCityTimelbl.AutoSize = true;
            this.TornCityTimelbl.Location = new System.Drawing.Point(328, 9);
            this.TornCityTimelbl.Name = "TornCityTimelbl";
            this.TornCityTimelbl.Size = new System.Drawing.Size(26, 13);
            this.TornCityTimelbl.TabIndex = 40;
            this.TornCityTimelbl.Text = "N/a";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 361);
            this.Controls.Add(this.TornCityTimelbl);
            this.Controls.Add(this.MainTabBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TornAPIData";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabBar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TornAPIKey;
        private System.Windows.Forms.Label APIkeylbl;
        private System.Windows.Forms.CheckBox ApiKeyLockcbx;
        private System.Windows.Forms.TabControl MainTabBar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lvlValuelbl;
        private System.Windows.Forms.Label lvllbl;
        private System.Windows.Forms.Label GenderValuelbl;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Label NameValuelbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDValuelbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Button GetDatabtn;
        private System.Windows.Forms.Label LifeValue;
        private System.Windows.Forms.Label Hplbl;
        private System.Windows.Forms.Label EnergyValuelbl;
        private System.Windows.Forms.Label Energylbl;
        private System.Windows.Forms.Label NerveValuelbl;
        private System.Windows.Forms.Label Nervelbl;
        private System.Windows.Forms.Label HappyValuelbl;
        private System.Windows.Forms.Label Happylbl;
        private System.Windows.Forms.Label ChainValuelbl;
        private System.Windows.Forms.Label Chainlbl;
        private System.Windows.Forms.LinkLabel VisitTornlbl;
        private System.Windows.Forms.Timer Refreshtimer;
        private System.Windows.Forms.Timer ButtonLimittimer;
        private System.Windows.Forms.Timer OneSecondtimer;
        private System.Windows.Forms.Timer OneSecondtimeTwo;
        private System.Windows.Forms.Label RefreshValuelbl;
        private System.Windows.Forms.Label refreshlbll;
        private System.Windows.Forms.Label ChainTimeoutlbl;
        private System.Windows.Forms.Label ChainTimeOutValuelbl;
        private System.Windows.Forms.Label PointsValuelbl;
        private System.Windows.Forms.Label MoneyOnHandlbl;
        private System.Windows.Forms.Label MoneyInVaultlbl;
        private System.Windows.Forms.Label CoolDownValuelbl;
        private System.Windows.Forms.Label Cooldownlbl;
        private System.Windows.Forms.Label TornCityTimelbl;
        private System.Windows.Forms.Label EnergyIncrementlbl;
        private System.Windows.Forms.Label NerveTimerValuelbl;
        private System.Windows.Forms.Label LifeTickValuelbl;
        private System.Windows.Forms.Label HappyTickValuelbl;
        private System.Windows.Forms.Label DrugCooldownValuelbl;
        private System.Windows.Forms.Label DrugCdlbl;
        private System.Windows.Forms.Label MedicalCooldownValue;
        private System.Windows.Forms.Label Medicallbl;
        private System.Windows.Forms.Label BoosterCdValuelbl;
        private System.Windows.Forms.Label BoosterCdlbl;
        private System.Windows.Forms.LinkLabel StatusLinkProfileValuelbl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button StockGetDatabtn;
        private System.Windows.Forms.Label CaymanbankValuelbl;
        private System.Windows.Forms.Label CityBankValuelbl;
        private System.Windows.Forms.Label BankTimeLeftValuelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label APILengthWarning;
        private System.Windows.Forms.Label NewMessagesValuelbl;
        private System.Windows.Forms.Label NewEventValuelbl;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button BrowseFileToReadAndSavebtn;
        private System.Windows.Forms.TextBox FileToReadtoAndSaveTotxtbox;
        private System.Windows.Forms.Label FileToSaveAndReadItemNameAndId;
        private System.Windows.Forms.Button GetItemNamesAndIdbtn;
        private System.Windows.Forms.Label SettingsAPIkeylbl;
        private System.Windows.Forms.CheckBox SettingsAPILockchkbox;
        private System.Windows.Forms.TextBox SettingsAPIKeyValuetxtbox;
        private System.Windows.Forms.Label SettingsDescriptionlbl;
        private System.Windows.Forms.Button SaveSettingsbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

