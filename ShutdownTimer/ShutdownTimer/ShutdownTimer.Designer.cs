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
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpPowersave = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grpReboot = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grpLock = new System.Windows.Forms.GroupBox();
            this.chkTimed = new System.Windows.Forms.CheckBox();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.grpInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpShutdown.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpPowersave.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpReboot.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grpLock.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.grpInput.Size = new System.Drawing.Size(184, 107);
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
            this.txtSeconds.Size = new System.Drawing.Size(28, 20);
            this.txtSeconds.TabIndex = 5;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinutes.Location = new System.Drawing.Point(71, 42);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(28, 20);
            this.txtMinutes.TabIndex = 4;
            // 
            // txtHours
            // 
            this.txtHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHours.Location = new System.Drawing.Point(71, 16);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(28, 20);
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
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdownInstant_Click);
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
            this.btnHibernate.Location = new System.Drawing.Point(6, 51);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(181, 26);
            this.btnHibernate.TabIndex = 4;
            this.btnHibernate.Text = "Ruhezustand";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStandby.Location = new System.Drawing.Point(6, 19);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(181, 26);
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
            this.btnRestart.Size = new System.Drawing.Size(175, 26);
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
            this.btnLogoff.Size = new System.Drawing.Size(181, 26);
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
            this.btnLock.Size = new System.Drawing.Size(181, 26);
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "Sperren";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(218, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 26);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.grpInput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 113);
            this.panel1.TabIndex = 10;
            // 
            // btnSoftRestart
            // 
            this.btnSoftRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoftRestart.Location = new System.Drawing.Point(6, 51);
            this.btnSoftRestart.Name = "btnSoftRestart";
            this.btnSoftRestart.Size = new System.Drawing.Size(175, 38);
            this.btnSoftRestart.TabIndex = 10;
            this.btnSoftRestart.Text = "Neustart && Sitzung wiederherstellen";
            this.btnSoftRestart.UseVisualStyleBackColor = true;
            this.btnSoftRestart.Click += new System.EventHandler(this.btnSoftRestart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpShutdown);
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 90);
            this.panel2.TabIndex = 11;
            // 
            // grpShutdown
            // 
            this.grpShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShutdown.Controls.Add(this.btnShutdownAbort);
            this.grpShutdown.Controls.Add(this.btnShutdown);
            this.grpShutdown.Location = new System.Drawing.Point(4, 4);
            this.grpShutdown.Name = "grpShutdown";
            this.grpShutdown.Size = new System.Drawing.Size(182, 83);
            this.grpShutdown.TabIndex = 0;
            this.grpShutdown.TabStop = false;
            this.grpShutdown.Text = "Herunterfahren";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpPowersave);
            this.panel3.Location = new System.Drawing.Point(211, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 88);
            this.panel3.TabIndex = 12;
            // 
            // grpPowersave
            // 
            this.grpPowersave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPowersave.Controls.Add(this.btnHibernate);
            this.grpPowersave.Controls.Add(this.btnStandby);
            this.grpPowersave.Location = new System.Drawing.Point(4, 4);
            this.grpPowersave.Name = "grpPowersave";
            this.grpPowersave.Size = new System.Drawing.Size(193, 81);
            this.grpPowersave.TabIndex = 0;
            this.grpPowersave.TabStop = false;
            this.grpPowersave.Text = "Energiesparen";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grpReboot);
            this.panel4.Location = new System.Drawing.Point(211, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 103);
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
            this.grpReboot.Size = new System.Drawing.Size(187, 97);
            this.grpReboot.TabIndex = 0;
            this.grpReboot.TabStop = false;
            this.grpReboot.Text = "Neustart";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grpLock);
            this.panel5.Location = new System.Drawing.Point(417, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 91);
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
            this.grpLock.Size = new System.Drawing.Size(193, 85);
            this.grpLock.TabIndex = 0;
            this.grpLock.TabStop = false;
            this.grpLock.Text = "Sperren";
            // 
            // chkTimed
            // 
            this.chkTimed.AutoSize = true;
            this.chkTimed.Location = new System.Drawing.Point(12, 131);
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
            this.chkForce.Location = new System.Drawing.Point(12, 155);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(148, 17);
            this.chkForce.TabIndex = 16;
            this.chkForce.Text = "Herunterfahren erzwingen";
            this.chkForce.UseVisualStyleBackColor = true;
            // 
            // FShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 534);
            this.Controls.Add(this.chkForce);
            this.Controls.Add(this.chkTimed);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
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
            this.panel3.ResumeLayout(false);
            this.grpPowersave.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpPowersave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpReboot;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grpLock;
        private System.Windows.Forms.CheckBox chkTimed;
        private System.Windows.Forms.CheckBox chkForce;
    }
}

