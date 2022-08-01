using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Task_Grabber
{
    public partial class Task_Grabber : Form
    {
        public delegate void DELETEGATE();
        
        public Task_Grabber()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }
        private void Task_Grabber_Load(object sender, EventArgs e)
        {
            Get_Config("Profile", "loadprofiles");
            Profile.SelectedIndex = 0;
            Panel_Custom_H = Panel_Custom.Height;
            Panel_Custom.Visible = false;
            this.Height -= Panel_Custom_H;
            textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            Expand_Click(new object(), new EventArgs());
            ConfigPath = CD + "\\Configs.txt";
            Config_Backup = CD + "\\Configs_Backup.txt";
            Load_Defaults();
            Timer.Text = "15 30";
            Min = 15; Max = 30;
            CountDown = new System.Windows.Forms.Timer();
            CountDown.Interval = 1000;
            CheckWeb = new System.Windows.Forms.Timer();
            CheckWeb.Interval = 1000 * 60 * 2;
        }
//Resise_Window_____
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style = (cp.Style | 262144);
                return cp;
            }
        }
        //
//Drag_Window_____
        int mov, movX, movY;
        private void Panel_Body_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Panel_Body_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void Panel_Body_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //
        //Methods_____Methods_____Methods_____Methods_____Methods_____Methods_____Methods_____Methods_____
        //
//Mode_____
        string headless = "Running in Headless Mode ";
        public void Mode()
        {
            if (Headless)
            {
                Head.ForeColor = Color.Red;
                Head.Text = "Headless_Mode";
                Head.BackColor = Color.Lime;
            }
            else
            {
                headless = "Running in Normal Mode ";
                Head.ForeColor = Color.Black;
                Head.Text = "Normal_Mode";
                Head.BackColor = Color.DarkCyan;
            }
            LOG(headless);
        }
//Load_Defaults_____
        public void Load_Defaults()
        {
            Get_Config(null, "all");//Store Configs to Config[]
            string[] defaults = new string[] { "Dash:" , "Lidar_Q:" , "Modem_Block:" , "StartXPath:" , "ExpiredXPath:" };
            for (Config_Index = 0; Config_Index < Configs.Length; Config_Index++)//Get Value of the first keyword
            {
                foreach (string values in defaults)
                {
                    try
                    {
                        if (Configs[Config_Index].Contains(values))
                        {
                            TextValue = Configs[Config_Index].ToString();
                            TextValue = TextValue.Replace(values, "");
                            TextValue = TextValue.Remove(0, 1);
                            TextValue = TextValue.Trim();
                            LOG(values + " " + TextValue);
                            if(values == "Dash:") { Dash = TextValue; }
                            else if(values == "Lidar_Q:") { Lidar_Q = TextValue; }
                            else if (values == "Modem_Block:") { Modem_Block = TextValue; }
                            else if (values == "StartXPath:") { StartXPath = TextValue; }
                            else if (values == "ExpiredXPath:") { ExpiredXPath = TextValue; }  
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
//Get_Config_____
        int Config_Index;
        string TextValue;
        string[] Configs;
        public string Get_Config(string keyword, string method)
        {
            StreamReader Value = new StreamReader("Configs.txt");
            TextValue = Value.ReadToEnd();
            Configs = TextValue.Split('\n');
            if (method == null)
            {
                for (Config_Index = 0; Config_Index < Configs.Length; Config_Index++)//Get Value of the first keyword
                {
                    if (Configs[Config_Index].Contains(keyword))
                    {
                        TextValue = Configs[Config_Index].ToString();
                        TextValue = TextValue.Replace(keyword, "");
                        TextValue = TextValue.Remove(0, 1);
                        break;
                    }
                }
                Value.Close();
            }
            else if (method == "all")
            {
                TextValue = null;
                foreach (string configs in Configs) { TextValue += configs + Environment.NewLine; }
            }
            else
            {
                if (method == "loadprofiles")//Get all the Values of the same keyword
                {
                    Profile.Items.Clear();
                    foreach (string profiles in Configs)
                    {
                        if (profiles.Contains(keyword))
                        {
                            TextValue = profiles.Remove(0, 10);
                            string[] Prof = TextValue.Split(' ');
                            Profile.Items.Add(Prof[0]);
                            Prof_Path += Prof[1] + Environment.NewLine;
                        }
                    }
                    TextValue = null;
                }
            }
            return TextValue;
        }
        //
//LOG_____
        public void LOG(String msg) //This Method is to access Resources from a new Thread to Main Thread like TextBox//Can only be called directly from main Threa//
        {
            Delegate log = new DELETEGATE(() => 
            {
                textScripts.Text += (msg);
                textScripts.AppendText(Environment.NewLine);
                if (Timer.Text == null)
                {
                    Timer.Text = Min.ToString() + " " + Max.ToString();
                }
            });
            this.Invoke(log);
        }
        //
//Beep_____
        public void Beep(int frq, int time) { System.Console.Beep(frq, time); }
//Beep_Block_____
        public void Beep_Block()
        {
            Beep(500, 500);
            Beep(1000, 400);
            Beep(2000, 400);
        }
//Beep_Link_____
        public void Beep_Link(int times)
        {
            if (times == 1) { Beep(500, 1000); }
            else if (times == 2)
            {
                Beep(500, 500);
                Beep(500, 500);
            }
        }
//Show_Status()
        public void Show_Status()
        {
            string Status = "Version " + Version.Text + Environment.NewLine
                + "Refresh Time: " + Min.ToString() + " to " + Max.ToString() + Environment.NewLine
                + "Profile: " + Profile_PATH + Environment.NewLine
                + "Lidar_Queue: >" + Lidar_Q + "<" + Environment.NewLine
                + "Music Path: " + Get_Config("Music_Path:", null);
            LOG(Status);
        }
//Generate Random Refresh Time_____ 
        public int Rtime()
        {
            keydown = false;
            Timer_KeyDown(new object(), new KeyEventArgs(Keys.Enter));
            keydown = true;
            Random rt = new Random();
            int rtime = rt.Next(Min, Max);
            return rtime;
        }
        //
        //Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____Buttons_____
        //
//Start_____
        bool start = false;
        private void Start_Click(object sender, EventArgs e)
        {
            if (start)
            {
                Start.Text = "Start";
                start = false;
                Play = false;
                Start.BackColor = Color.DeepSkyBlue;
                panel_Body.BackColor = Color.LightSkyBlue;
                CountDown.Enabled = false;
                CheckWeb.Enabled = false;
            }
            else  //Start Checking the Brower
            {
                Start.Text = "Stop";
                start = true;
                Start.BackColor = Color.Red;
                panel_Body.BackColor = Color.LightGreen;
                LOG("Always Set Zoom Level to 100% to make Click Work..");
                CountDown.Enabled = true;
            }
        }
        //
//Load Chrome_Profile_____
        private void Load_Profile_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcessesByName("chromedriver")) { p.CloseMainWindow(); }
            try
            {
                Load_WebDriver();
                Show_Status();//need to put here since not working under Task_Grabber_Load()
            }
            catch (Exception ex)
            {
                LOG("General Exception under Load_Profile_Click");
                LOG(ex.ToString());
            }
        }
        //
        private void Clear_Scripts_Click(object sender, EventArgs e)
        {
            Beep(1000, 500);
            Refreshed = 0; RefreshX.Clear(); textScripts.Clear(); Value.Clear();
        }
        private void Find_Element_Click(object sender, EventArgs e)
        {
            Input_T_M_V("XPath", "Find", value);
            Find_element(null);
        }
        private void Click_Element_Click(object sender, EventArgs e)
        {
            Input_T_M_V("XPath", "Click", value);
            Find_element(null);
        }
        //
//Always on Top_____
        bool top = false;
        private void Always_Top_Click(object sender, EventArgs e)
        {
            if (top)
            {
                Always_Top.Text = "T";
                top = false;
                this.TopMost = false;
            }
            else  //Lock Window
            {
                Always_Top.Text = "U";
                top = true;
                this.TopMost = true;
            }
        }
        private void Minimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void Close_Click(object sender, EventArgs e) { Application.Exit(); }
        //
//Expand_Window_____
        bool Expand = false;
        private void Expand_Click(object sender, EventArgs e)
        {
            if (Expand)
            {
                Xpand.Text = "Xpand";
                Expand = false;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                Panel_Custom.Visible = false;
                this.Height -= Panel_Custom_H;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            }
            else //Expand
            {
                Xpand.Text = "Hide";
                Expand = true;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                this.Height += Panel_Custom_H;
                Panel_Custom.Visible = true;
                Panel_Custom.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                textScripts.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            }
        }
        //
//Play_____
        bool Play = false;
        SoundPlayer player;
        private void Sound_Click(object sender, EventArgs e)
        {
            try
            {
                player = new SoundPlayer(Get_Config("Music_Path:", null));
                if (Play)
                {
                    Sound.Text = "Sound";
                    Play = false;
                    player.Stop();
                }
                else //Play Sound
                {
                    LOG("Playing: " + Get_Config("Music_Path:", null));
                    Sound.Text = "Stop";
                    Play = true;
                    player.PlayLooping();
                }
            }
            catch (Exception ex) { LOG(ex.ToString()); }
        }
        //
//Help_____
        private void Help_Click(object sender, EventArgs e)
        {
            string Help = "Show Status : Show Current Configuration//" + Environment.NewLine
                + "Show Configs : Show Configs From Configs.txt//" + Environment.NewLine
                + "Set Q : Set LiDAR Queue Link//" + Environment.NewLine
                + "Set Sound : Set Background Sound//" + Environment.NewLine
                //+ "Set Profile : Set Chrome Custome Profile//" + Environment.NewLine
                + "Show Xpaths : Show Xpaths Samples From Xpath_Notes.txt//" + Environment.NewLine
                + "Config_Editor : Run Config Editor//" + Environment.NewLine
                + "Values : Show Current Variabe Values//" + Environment.NewLine
                + "Backup_Config : Backup Current Configs to Configs_Backup.txt//" + Environment.NewLine
                + "Stop : Stop all Running Threads//";
            LOG(Help);
        }
        //
//Window_Check_____
        public string[] WinArray;
        private async void WinCheck_Click(object sender, EventArgs e)//private void Window_Click
        {
            await Task.Run(new Action(Windows));
            try
            {
                WinArray = WinString.Split('\n');
                for (int i = 0; i < Chrome.WindowHandles.Count(); i++)
                {
                    if (WinArray[i].Contains(Chrome.CurrentWindowHandle)) { LOG("Current Window: " + WinArray[i]); }
                }
            }
            catch (Exception ex) { LOG(ex.ToString()); }
        }
        //TextBox & ComboBox_____
//Console_____
            private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LOG(Date_Time() + " Executing Command from Console..");
                try
                {
                    string[] Inputarray = Console.Text.Split(' ');
                    if (Inputarray[0] == "Show")
                    {
                        if (Inputarray[1] == "Status")//Status
                        {
                            Show_Status();
                        }
                        else if (Inputarray[1] == "Configs")
                        {
                            StreamReader Value = new StreamReader("Configs.txt");
                            TextValue = Value.ReadToEnd();
                            LOG(TextValue);
                        }
                        else if (Inputarray[1] == "Xpaths")//Show Xpath Samples
                        {
                            StreamReader Value = new StreamReader("Xpath_Notes.txt");
                            TextValue = Value.ReadToEnd();
                            LOG(TextValue);
                        }
                    }
                    else if (Inputarray[0] == "Set")//Set Values
                    {
                        if (Inputarray[1] == "Sound")//Set Sound
                        {
                            string musicfolder = Environment.CurrentDirectory + @"\Music";
                            LOG(musicfolder + " | Select or Replace WAV Music..");
                            openFileDialog.InitialDirectory = musicfolder;
                            DialogResult music = openFileDialog.ShowDialog();
                            if (music == DialogResult.OK)
                            {
                                string musicpath = openFileDialog.FileName;
                                LOG(Get_Config("Music_Path:", null));
                                //Set_Config("Music_Path:", musicpath, ConfigPath);
                            }
                        }
                        else if (Inputarray[1] == "Q")
                        {
                            LOG("Current Lidar Q: " + Get_Config("Lidar_Q:", null) + Environment.NewLine
                                + "Set Q https://www.Newlink.com");
                            if (Inputarray.Length == 3)
                            {
                                //Set_Config("Lidar_Q:", Inputarray[2], ConfigPath);
                                LOG("New Lidar Q: " + Get_Config("Lidar_Q:", null));
                            }
                        }
                        else if (Inputarray[1] == "Profile")
                        {
                            LOG("Set Profile 'Profile#: to edit' 'Name' 'Path'" + Environment.NewLine
                                + "E.g. >Set Profile Profile1: Jessie D:\\Chrome_Jessie<");
                            try
                            {
                                string newtext = Inputarray[3] + " " + Inputarray[4];
                                //Set_Config(Inputarray[2], newtext, ConfigPath);
                                LOG("New >" + Inputarray[2] + " " + newtext + "<");
                            }
                            catch (Exception) { LOG("Profile number not found"); };
                        }
                    }
                    else if (Inputarray[0] == "Stop") { }
                    else if (Inputarray[0] == "Backup_Config")
                    {
                        string[] Lines = Get_Config(null, "all").Split('\n');
                        File.WriteAllLines(Config_Backup, Lines);
                        LOG("Backup Complete to " + Config_Backup);
                    }
                    else if (Inputarray[0] == "Config_Editor") { new Config_Editor(this).Show(); }
                    else if (Inputarray[0] == "Values") { Load_Defaults(); }
                    else if ((Inputarray[0] == "Headless_ON")) { Headless = true; Mode(); }
                    else if ((Inputarray[0] == "Headless_OFF")) { Headless = false; Mode(); }
                    else if ((Inputarray[0] == "Goto_Dash")) { Navi(Dash); }
                    else { LOG("Command not Recognoezd.."); }
                }
                catch (Exception ex)
                {
                    LOG("General Exception under Console_KeyDown()");
                    LOG(ex.ToString());
                }
                LOG("Always Backup Config");
            }
        }
        //Console_END_____
        //
        //Event_Listeners_____
        //

//Timer_KeyDown_____
        bool keydown = true;
        private void Timer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (keydown)
                    {
                        string[] Inputarray = Timer.Text.Split(' ');
                        Min = int.Parse(Inputarray[0]);
                        Max = int.Parse(Inputarray[1]);
                        string minmax = "" + Min.ToString() + " " + Max.ToString() + " ";
                        Timer.Text = minmax;
                        if (keydown)
                        {
                            LOG("Refresh Time Set FromTo: " + minmax);
                        }
                    }
                }
                catch (Exception) { Timer.Clear(); LOG("MinMax in Wrong Format..>Min Max<"); }
            }
        }
//Windows_Index_____
        int tabindex;
        string number;
        string[] num;
        private void Win_Index_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    number = Win_Index.Text;
                    num = new string[] { number };
                    number = num.Last();
                    number = number.Trim();
                    tabindex = int.Parse(number);
                    LOG(tabindex.ToString());
                    Win_Index.Clear();
                    Win_Index.Text = number;
                }
                catch (Exception ex) { LOG(ex.ToString()); }
                WinSwitch(tabindex);
            }
        }
        //
        private void Value_TextChanged(object sender, EventArgs e) { value = Value.Text; }
        string Prof_Path;//Store PATH of every profile from ComboBox
        private void Profile_SelectedIndexChanged(object sender, EventArgs e) 
        {
            string[] path = Prof_Path.Split('\n');
            Profile_PATH = path[Profile.SelectedIndex];
        }
    }
}
