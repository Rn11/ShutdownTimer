using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class FShutdownTimer : Form
    {

        public FShutdownTimer()
        {
            InitializeComponent();
        }

        private void startProcess(string action, string args)
        {
            var info = new ProcessStartInfo(action, args);
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process.Start(info);
        }

        private int convertTime(string hours, string minutes, string seconds)
        {
            int time = 0;
            time = (Convert.ToInt32(seconds) + (Convert.ToInt32(minutes) * 60) + (Convert.ToInt32(hours) * 3600));
            return time;
        }

        private void btnShutdownTimed_Click(object sender, EventArgs e)
        {
            startProcess("shutdown", "/s /t " + convertTime(txtHours.Text, txtMinutes.Text, txtSeconds.Text).ToString());
        }

        private void btnShutdownAbort_Click(object sender, EventArgs e)
        {
            startProcess("shutdown", "/a");
        }

        private void btnShutdownInstant_Click(object sender, EventArgs e)
        {
            startProcess("shutdown", "/s /f");
        }

        private void btnHibernate_Click(object sender, EventArgs e)
        {
            startProcess("shutdown", "/h");
        }

        private void btnStandby_Click(object sender, EventArgs e)
        {
            startProcess("rundll32.exe powrprof.dll,", "SetSuspendState");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {

        }

        private void btnLock_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
