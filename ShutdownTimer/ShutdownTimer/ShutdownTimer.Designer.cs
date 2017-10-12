namespace ShutdownTimer
{
    partial class FShutdownTimer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinues = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnShutdownAbort = new System.Windows.Forms.Button();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnStandby = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSoftRestart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpShutdown = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grpReboot = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grpLock = new System.Windows.Forms.GroupBox();
            this.chkTimed = new System.Windows.Forms.CheckBox();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.prgTime = new System.Windows.Forms.ProgressBar();
            this.lblTimeLeftDescription = new System.Windows.Forms.Label();
            this.lblTimeLeftValue = new System.Windows.Forms.Label();
            this.lblVersionDescription = new System.Windows.Forms.Label();
            this.lblVersionValue = new System.Windows.Forms.Label();
            this.timerUntilAction = new System.Windows.Forms.Timer(this.components);
            this.grpInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpShutdown.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpReboot.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grpLock.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpInput.Controls.Add(this.txtSeconds);
            this.grpInput.Controls.Add(this.txtMinutes);
            this.grpInput.Controls.Add(this.txtHours);
            this.grpInput.Controls.Add(this.lblSeconds);
            this.grpInput.Controls.Add(this.lblMinues);
            this.grpInput.Controls.Add(this.lblHours);
            this.grpInput.Enabled = false;
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(156, 95);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Zeiteingabe";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeconds.Location = new System.Drawing.Point(71, 68);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(71, 20);
            this.txtSeconds.TabIndex = 5;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinutes.Location = new System.Drawing.Point(71, 42);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(71, 20);
            this.txtMinutes.TabIndex = 4;
            // 
            // txtHours
            // 
            this.txtHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHours.Location = new System.Drawing.Point(71, 16);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(71, 20);
            this.txtHours.TabIndex = 3;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(6, 71);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(59, 13);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "Sekunden:";
            // 
            // lblMinues
            // 
            this.lblMinues.AutoSize = true;
            this.lblMinues.Location = new System.Drawing.Point(6, 45);
            this.lblMinues.Name = "lblMinues";
            this.lblMinues.Size = new System.Drawing.Size(48, 13);
            this.lblMinues.TabIndex = 1;
            this.lblMinues.Text = "Minuten:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(6, 19);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 13);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Stunden:";
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdown.Location = new System.Drawing.Point(6, 19);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(170, 26);
            this.btnShutdown.TabIndex = 3;
            this.btnShutdown.Text = "Herunterfahren";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnShutdownAbort
            // 
            this.btnShutdownAbort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdownAbort.Location = new System.Drawing.Point(6, 51);
            this.btnShutdownAbort.Name = "btnShutdownAbort";
            this.btnShutdownAbort.Size = new System.Drawing.Size(170, 26);
            this.btnShutdownAbort.TabIndex = 2;
            this.btnShutdownAbort.Text = "Herunterfahren abbrechen";
            this.btnShutdownAbort.UseVisualStyleBackColor = true;
            this.btnShutdownAbort.Click += new System.EventHandler(this.btnShutdownAbort_Click);
            // 
            // btnHibernate
            // 
            this.btnHibernate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHibernate.Location = new System.Drawing.Point(6, 115);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(170, 26);
            this.btnHibernate.TabIndex = 4;
            this.btnHibernate.Text = "Ruhezustand";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStandby.Location = new System.Drawing.Point(6, 83);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(170, 26);
            this.btnStandby.TabIndex = 5;
            this.btnStandby.Text = "Energiesparmodus";
            this.btnStandby.UseVisualStyleBackColor = true;
            this.btnStandby.Click += new System.EventHandler(this.btnStandby_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Location = new System.Drawing.Point(6, 19);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(170, 26);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Neustart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoff.Location = new System.Drawing.Point(6, 19);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(144, 26);
            this.btnLogoff.TabIndex = 7;
            this.btnLogoff.Text = "Abmelden";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnLock
            // 
            this.btnLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLock.Location = new System.Drawing.Point(6, 51);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(144, 26);
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "Sperren";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(276, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.grpInput);
            this.panel1.Location = new System.Drawing.Point(211, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 103);
            this.panel1.TabIndex = 10;
            // 
            // btnSoftRestart
            // 
            this.btnSoftRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoftRestart.Location = new System.Drawing.Point(6, 51);
            this.btnSoftRestart.Name = "btnSoftRestart";
            this.btnSoftRestart.Size = new System.Drawing.Size(170, 38);
            this.btnSoftRestart.TabIndex = 10;
            this.btnSoftRestart.Text = "Neustart && Sitzung wiederherstellen";
            this.btnSoftRestart.UseVisualStyleBackColor = true;
            this.btnSoftRestart.Click += new System.EventHandler(this.btnSoftRestart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpShutdown);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 157);
            this.panel2.TabIndex = 11;
            // 
            // grpShutdown
            // 
            this.grpShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShutdown.Controls.Add(this.btnHibernate);
            this.grpShutdown.Controls.Add(this.btnShutdownAbort);
            this.grpShutdown.Controls.Add(this.btnStandby);
            this.grpShutdown.Controls.Add(this.btnShutdown);
            this.grpShutdown.Location = new System.Drawing.Point(4, 4);
            this.grpShutdown.Name = "grpShutdown";
            this.grpShutdown.Size = new System.Drawing.Size(182, 150);
            this.grpShutdown.TabIndex = 0;
            this.grpShutdown.TabStop = false;
            this.grpShutdown.Text = "Herunterfahren";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grpReboot);
            this.panel4.Location = new System.Drawing.Point(12, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 103);
            this.panel4.TabIndex = 13;
            // 
            // grpReboot
            // 
            this.grpReboot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReboot.Controls.Add(this.btnSoftRestart);
            this.grpReboot.Controls.Add(this.btnRestart);
            this.grpReboot.Location = new System.Drawing.Point(4, 3);
            this.grpReboot.Name = "grpReboot";
            this.grpReboot.Size = new System.Drawing.Size(182, 97);
            this.grpReboot.TabIndex = 0;
            this.grpReboot.TabStop = false;
            this.grpReboot.Text = "Neustart";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grpLock);
            this.panel5.Location = new System.Drawing.Point(211, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(162, 92);
            this.panel5.TabIndex = 14;
            // 
            // grpLock
            // 
            this.grpLock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLock.Controls.Add(this.btnLock);
            this.grpLock.Controls.Add(this.btnLogoff);
            this.grpLock.Location = new System.Drawing.Point(3, 3);
            this.grpLock.Name = "grpLock";
            this.grpLock.Size = new System.Drawing.Size(156, 86);
            this.grpLock.TabIndex = 0;
            this.grpLock.TabStop = false;
            this.grpLock.Text = "Sperren";
            // 
            // chkTimed
            // 
            this.chkTimed.AutoSize = true;
            this.chkTimed.Location = new System.Drawing.Point(211, 49);
            this.chkTimed.Name = "chkTimed";
            this.chkTimed.Size = new System.Drawing.Size(88, 17);
            this.chkTimed.TabIndex = 15;
            this.chkTimed.Text = "Zeitgesteuert";
            this.chkTimed.UseVisualStyleBackColor = true;
            this.chkTimed.CheckedChanged += new System.EventHandler(this.chkTimed_CheckedChanged);
            // 
            // chkForce
            // 
            this.chkForce.AutoSize = true;
            this.chkForce.Location = new System.Drawing.Point(211, 26);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(148, 17);
            this.chkForce.TabIndex = 16;
            this.chkForce.Text = "Herunterfahren erzwingen";
            this.chkForce.UseVisualStyleBackColor = true;
            // 
            // prgTime
            // 
            this.prgTime.Location = new System.Drawing.Point(12, 311);
            this.prgTime.Name = "prgTime";
            this.prgTime.Size = new System.Drawing.Size(365, 23);
            this.prgTime.TabIndex = 17;
            // 
            // lblTimeLeftDescription
            // 
            this.lblTimeLeftDescription.AutoSize = true;
            this.lblTimeLeftDescription.Location = new System.Drawing.Point(12, 292);
            this.lblTimeLeftDescription.Name = "lblTimeLeftDescription";
            this.lblTimeLeftDescription.Size = new System.Drawing.Size(97, 13);
            this.lblTimeLeftDescription.TabIndex = 18;
            this.lblTimeLeftDescription.Text = "Zeit bis zur Aktion: ";
            // 
            // lblTimeLeftValue
            // 
            this.lblTimeLeftValue.AutoSize = true;
            this.lblTimeLeftValue.Location = new System.Drawing.Point(115, 292);
            this.lblTimeLeftValue.Name = "lblTimeLeftValue";
            this.lblTimeLeftValue.Size = new System.Drawing.Size(23, 13);
            this.lblTimeLeftValue.TabIndex = 19;
            this.lblTimeLeftValue.Text = "null";
            this.lblTimeLeftValue.Visible = false;
            // 
            // lblVersionDescription
            // 
            this.lblVersionDescription.AutoSize = true;
            this.lblVersionDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersionDescription.Location = new System.Drawing.Point(13, 346);
            this.lblVersionDescription.Name = "lblVersionDescription";
            this.lblVersionDescription.Size = new System.Drawing.Size(45, 13);
            this.lblVersionDescription.TabIndex = 20;
            this.lblVersionDescription.Text = "Version:";
            // 
            // lblVersionValue
            // 
            this.lblVersionValue.AutoSize = true;
            this.lblVersionValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersionValue.Location = new System.Drawing.Point(55, 346);
            this.lblVersionValue.Name = "lblVersionValue";
            this.lblVersionValue.Size = new System.Drawing.Size(31, 13);
            this.lblVersionValue.TabIndex = 21;
            this.lblVersionValue.Text = "0.0.0";
            // 
            // timerUntilAction
            // 
            this.timerUntilAction.Interval = 1000;
            this.timerUntilAction.Tick += new System.EventHandler(this.timerUntilAction_Tick);
            // 
            // FShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 377);
            this.Controls.Add(this.lblVersionValue);
            this.Controls.Add(this.lblVersionDescription);
            this.Controls.Add(this.lblTimeLeftValue);
            this.Controls.Add(this.lblTimeLeftDescription);
            this.Controls.Add(this.prgTime);
            this.Controls.Add(this.chkForce);
            this.Controls.Add(this.chkTimed);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FShutdownTimer";
            this.Text = "ShutdownTimer";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpShutdown.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grpReboot.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grpLock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinues;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnShutdownAbort;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSoftRestart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpShutdown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpReboot;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grpLock;
        private System.Windows.Forms.CheckBox chkTimed;
        private System.Windows.Forms.CheckBox chkForce;
        private System.Windows.Forms.ProgressBar prgTime;
        private System.Windows.Forms.Label lblTimeLeftDescription;
        private System.Windows.Forms.Label lblTimeLeftValue;
        private System.Windows.Forms.Label lblVersionDescription;
        private System.Windows.Forms.Label lblVersionValue;
        private System.Windows.Forms.Timer timerUntilAction;
    }
}

