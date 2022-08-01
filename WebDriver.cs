using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Linq;

namespace Task_Grabber
{
    public partial class Task_Grabber
    {
        public String ConfigPath;
        public String Config_Backup;
        public String CD = Environment.CurrentDirectory;
        public int Min;
        public int Max;
        public String Myurl;
        public static String value;
        public static String FindElementType;
        public static String ElementMethod;
        int Panel_Custom_H; //Store Panel_Custom Height
        //-------------------------------------
        public String Webtext;
        public String Modem_Block;
        public String link1;
        public String link2;
        public String Dash;
        public String Lidar_Q;
        public String StartXPath;
        public String ExpiredXPath;
        public String ContinueXPath;
        //
        //String Methods//
        //
        public string Date_Time()
        {
            string DT = DateTime.Now.ToString();
            string Date_Time = DT.Replace("/", "_");
            Date_Time = Date_Time.Replace(":", "_");
            Date_Time = Date_Time.Replace(" ", "_");
            return Date_Time;
        }
        public static String Input_T_M_V(String Type, String Method, String value1)
        {
            FindElementType = Type;
            ElementMethod = Method;
            value = value1;
            return FindElementType + ElementMethod + value;
        }
        public String Type_Method_value()
        {
            string Type_Method_value = "FindElement By." + FindElementType + "_" + ElementMethod + "  Value: " + value;
            return Type_Method_value;
        }
//Get Current URL_____
        public string URL;
        public String Curl()
        {
            try { URL = Chrome.Url; }
            catch (ThreadAbortException) { }
            catch (Exception ex) { LOG("General Exception under Curl()"); LOG(ex.ToString()); }
            if (URL == null) { return "Url Not Found/Window not Active"; }
            else { return URL; }
        }
        //
//Chrome Driver_____
        IWebDriver Chrome;
        public String Profile_PATH;
        bool Headless = false;
        public void Load_WebDriver()
        {
            Mode();
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("user-data-dir=" + Profile_PATH);
                if (Headless) { options.AddArguments("--headless"); }
                Chrome = new ChromeDriver(options);
                LOG("Profile Path: " + Profile_PATH);
            }
            catch (Exception ex)
            {
                LOG("General Exception under Chrome Options");
                LOG(ex.ToString());
            }
        }
        //
//WinSwitch_____
        public string WinString;
        public void Windows()
        {
            WinString = null;
            try
            {
                LOG(Chrome.WindowHandles.Count().ToString() + " Window");
                for (int i = 0; i < Chrome.WindowHandles.Count(); i++)
                {
                    Chrome.SwitchTo().Window(Chrome.WindowHandles[i]);
                    WinString += "Index: " + i + " _ " + Curl() + " __ " + Chrome.CurrentWindowHandle;
                    if (i < Chrome.WindowHandles.Count() - 1) { WinString += Environment.NewLine; }
                }
            }
            catch (Exception ex) { LOG(ex.ToString()); }
            LOG(WinString);
        }
        public void WinSwitch(int tab)
        {
            try
            {
                Chrome.SwitchTo().Window(Chrome.WindowHandles[tab]);
                LOG("Switch to: " + WinArray[tab]);
            }
            catch (Exception ex) { LOG("General Exception under WinSwitch()/Tab_Index not Found"); LOG(ex.ToString()); }
        }
        //
        //Methods//
        //
//Navigate_____
        Thread Navig;
        bool loading = true;
        public void Navi(string url)
        {
            loading = true;
            Navig = new Thread(() => {
                
                LOG("Loading.....");
                Myurl = url; Navigate();
                try { URL = Chrome.Url; } catch (Exception ex) { LOG(ex.ToString()); }
            wait:
                if (loading) { goto wait; }
                LOG("Current URL: " + URL);
            });
            Navig.Start();
            loading = false;
        }
        public void Navigate()
        {
        Again:
            try { Chrome.Navigate().GoToUrl(Myurl); }
            catch (WebDriverTimeoutException)
            {
                LOG("WebDriver Timeout Exception in Navi()");
                Thread.Sleep(Rtime());
                goto Again;
            }
            catch (Exception ex)
            {
                LOG("General Exception under Navi()");
                LOG(ex.ToString());
            }
        }
        //
        //Find_Button_____
        public void Find_Start() { Input_T_M_V("XPath", "Find", StartXPath); Find_element("Find_Start"); }

        public void Find_Expired() { Input_T_M_V("XPath", "Find", ExpiredXPath); Find_element("Find_Expired"); }
        public void Click_Start() { Input_T_M_V("XPath", "Click", StartXPath); Find_element(null); }
        //
//Find_element_____
        public void Find_element(string Find)
        {
        Again:
            try
            {
                if (FindElementType == "XPath")
                {
                    Finder(Chrome, Chrome.FindElement(By.XPath(value)));
                    if (Find == "Find_Start") { Webtext = "Startfound"; }
                    else if (Find == "Find_Expired") { Webtext = "Expired"; }
                    if (Find != null) { LOG(Webtext); }
                }
                else if (FindElementType == "Id") { Finder(Chrome, Chrome.FindElement(By.Id(value))); }
                else if (FindElementType == "Name") { Finder(Chrome, Chrome.FindElement(By.Name(value))); }
                else { }
            }
            catch (NoSuchElementException)
            {
                if (Find == "Find_Start") { Webtext = "Startnotfound"; }
                else if (Find == "Find_Expired") { Webtext = "NotExpired"; }
                if (Find != null) { LOG(Webtext); }
            }
            catch (WebDriverTimeoutException)
            {
                LOG("WebDriver Timeout Exception under Find_element()");
                Thread.Sleep(Rtime());
                goto Again;
            }
            catch (ElementNotInteractableException)
            {
                LOG("Element Not Interactable Exception under Find_element| Will try again after 10 Seconds..");
                Thread.Sleep(Rtime());
                goto Again;
            }
            catch (UnhandledAlertException)
            {
                LOG("Unhandled Alert Exception Occur_in Find_element");
                Thread.Sleep(Rtime());
            }
            catch (Exception ex)
            {
                LOG("General Exception under Find_element()");
                LOG(ex.ToString());
            }
        }
//Finder_____
        public void Finder(IWebDriver chrome, IWebElement element)  //IWebDriver chrome is just reserve
        {
            LOG(Type_Method_value());
            string X = element.Location.X.ToString();
            string Y = element.Location.Y.ToString();
            LOG("Element X Coordinates: " + X + "  |  Element X Coordinates: " + Y);
            try
            {
                if (ElementMethod == "Click") { element.Click(); LOG("Click Successful"); } else { }
            }
            catch (Exception ex)
            {
                LOG("General Exception under Finder()");
                LOG(ex.ToString());
            }
            Value.Text = value;
        }
    }
}
