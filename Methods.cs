using System;
using System.Threading;

namespace Task_Grabber
{
    public partial class Task_Grabber
    {
        private System.Windows.Forms.Timer _checkurl;
        public System.Windows.Forms.Timer CheckWeb
        {
            get { return _checkurl; }
            set
            {
                EventHandler value2 = CheckWeb_Tick;
                System.Windows.Forms.Timer CheckWeb = _checkurl;
                if (CheckWeb != null)
                {
                    CheckWeb.Tick -= value2;
                }
                _checkurl = value;
                CheckWeb = _checkurl;
                if (CheckWeb != null)
                {
                    CheckWeb.Tick += value2;
                }
            }
        }
        private System.Windows.Forms.Timer _countdown;

        public System.Windows.Forms.Timer CountDown
        {
            get { return _countdown; }
            set
            {
                EventHandler value2 = CountDown_Tick;
                System.Windows.Forms.Timer CountDown = _countdown;
                if (CountDown != null)
                {
                    CountDown.Tick -= value2;
                }
                _countdown = value;
                CountDown = _countdown;
                if (CountDown != null)
                {
                    CountDown.Tick += value2;
                }
            }
        }
        //

        public int rtime;
		bool cd = false;
		public void CountDown_Tick(object sender, EventArgs e)
		{
            if (!cd)
            {
                rtime = Rtime();
                cd = true;
                count_down.Text = rtime.ToString();
            }
            else { rtime -= 1; count_down.Text = rtime.ToString(); }
			//
            if (rtime <= 0)
            {
				cd = false;
                LOG("Checking URL..");
                Router();
            }
        }

		//
        public int Counter;
        public int Refreshed;
        public void Router()
        {
            if (Curl() == Dash) // Dashboard
            {
                Navi(Lidar_Q);
            }
            else if (Curl() == Lidar_Q) //Lidar Queue 
            {
                Navi(Lidar_Q);
                Counter += 1;
                Refreshed += 1;
                LOG("Refresh by: " + Counter.ToString() + "X  |  " + DateTime.Now.ToString());
                RefreshX.Text = Refreshed.ToString() + " X";
                if (Counter == 5)
                {
                    textScripts.Clear();
                    Counter = 0;
                }
            }
            else if (Curl() == Modem_Block)
            {
                Beep_Block();
                Thread.Sleep(5000);
            }
            else if (Curl() != Lidar_Q)
            {
                LOG("Lidar URL Changed..");
                Find_Start(); Click_Start();
                System.Console.Beep(1000, 500);
                Sound_Click(new object(), new EventArgs());
                Myurl = Curl();
                Thread.Sleep(Rtime());
                CountDown.Enabled = false;
                CheckWeb.Enabled = true;
            }
        }
        //
        public void CheckWeb_Tick(object sender, EventArgs e)
        {
            CountDown.Enabled = false;
            LOG("Will Check the Task every 2 minutes..");
            LOG(Date_Time() + " >" + Curl() + "<");
            Find_Expired();
            if (Webtext == "Expired")
            {
                player.Stop();
                Navi(Dash);
                CheckWeb.Enabled = false;
                CountDown.Enabled = true;
            }
            else if(Webtext != "NotExpired") { LOG("Webtext not Recognized.."); }
        }
    }
}
