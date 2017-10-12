using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            lblVersionValue.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void startProcess(string action, string args)
        {
            var info = new ProcessStartInfo(action, args);
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process.Start(info);
        }

        private string convertTime(string hours, string minutes, string seconds)
        {
            int time = 0;
            try
            {
                if (hours != "")
                {
                    time += Convert.ToInt32(hours) * 3600;
                }

                if (minutes != "")
                {
                    time += (Convert.ToInt32(minutes) * 60);
                }

                if (seconds != "")
                {
                    time += Convert.ToInt32(seconds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kritischer Fehler: " + ex.Message);
            }
            return Convert.ToString(time);
        }

        private void btnShutdownTimed_Click(object sender, EventArgs e)
        {
            // ---- deprecated - not in use -----
            try
            {
                startProcess("shutdown", "/s /t " + convertTime(txtHours.Text, txtMinutes.Text, txtSeconds.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kritischer Fehler: " + ex.Message);
            }
        }

        private void btnShutdownAbort_Click(object sender, EventArgs e)
        {
            startProcess("shutdown", "/a");
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkTimed.Checked)
                {
                    if (chkForce.Checked)
                    {
                        startProcess("shutdown", "/s /f /t " + convertTime(txtHours.Text, txtMinutes.Text, txtSeconds.Text));
                        initProgressBar(Convert.ToInt32(convertTime(txtHours.Text, txtMinutes.Text, txtSeconds.Text)));
                    }
                    else if (!chkForce.Checked)
                    {
                        startProcess("shutdown", "/s /t " + convertTime(txtHours.Text, txtMinutes.Text, txtSeconds.Text));
                        initProgressBar(Convert.ToInt32(convertTime(txtHours.Text, txtMinutes.Text, txtSeconds.Text)));
                    }
                }

                else if (!chkTimed.Checked)
                {
                    if (chkForce.Checked)
                    {
                        startProcess("shutdown", "/s /f");
                    }
                    else if (!chkForce.Checked)
                    {
                        startProcess("shutdown", "/s");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kritischer Fehler: " + ex.Message);
            }
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
            startProcess("shutdown", "/r");
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {

        }

        private void btnLock_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSoftRestart_Click(object sender, EventArgs e)
        {
            //This option reopens all active applications (beta)
            startProcess("shutdown", "/g");
        }

        private void chkTimed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimed.Checked)
            {
                grpInput.Enabled = true;
            }
            else
            {
                grpInput.Enabled = false;
            }
        }

        private void initProgressBar(int seconds)
        {
            prgTime.Maximum = seconds;
            prgTime.Step = 1;
            startTimer();
        }

        private void startTimer()
        {
            timerUntilAction.Enabled = true;
            timerUntilAction.Start(); 
            timerUntilAction.Interval = 1000;
        }

        private void timerUntilAction_Tick(object sender, EventArgs e)
        {
            if (prgTime.Value <= prgTime.Maximum)
            {
                prgTime.Value++;
            }
            else
            {
                timerUntilAction.Stop();
            }
        }
    }
}
