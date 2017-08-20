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
            this.btnShutdownTimed = new System.Windows.Forms.Button();
            this.btnShutdownInstant = new System.Windows.Forms.Button();
            this.btnShutdownAbort = new System.Windows.Forms.Button();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnStandby = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpInput.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(204, 97);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Zeiteingabe";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeconds.Location = new System.Drawing.Point(71, 65);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(48, 20);
            this.txtSeconds.TabIndex = 5;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinutes.Location = new System.Drawing.Point(71, 39);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(48, 20);
            this.txtMinutes.TabIndex = 4;
            // 
            // txtHours
            // 
            this.txtHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHours.Location = new System.Drawing.Point(71, 13);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(48, 20);
            this.txtHours.TabIndex = 3;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(6, 68);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(59, 13);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "Sekunden:";
            // 
            // lblMinues
            // 
            this.lblMinues.AutoSize = true;
            this.lblMinues.Location = new System.Drawing.Point(6, 42);
            this.lblMinues.Name = "lblMinues";
            this.lblMinues.Size = new System.Drawing.Size(48, 13);
            this.lblMinues.TabIndex = 1;
            this.lblMinues.Text = "Minuten:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(6, 16);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 13);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Stunden:";
            // 
            // btnShutdownTimed
            // 
            this.btnShutdownTimed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdownTimed.Location = new System.Drawing.Point(0, 106);
            this.btnShutdownTimed.Name = "btnShutdownTimed";
            this.btnShutdownTimed.Size = new System.Drawing.Size(210, 26);
            this.btnShutdownTimed.TabIndex = 1;
            this.btnShutdownTimed.Text = "Herunterfahren (Zeiteingabe)";
            this.btnShutdownTimed.UseVisualStyleBackColor = true;
            this.btnShutdownTimed.Click += new System.EventHandler(this.btnShutdownTimed_Click);
            // 
            // btnShutdownInstant
            // 
            this.btnShutdownInstant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdownInstant.Location = new System.Drawing.Point(0, 170);
            this.btnShutdownInstant.Name = "btnShutdownInstant";
            this.btnShutdownInstant.Size = new System.Drawing.Size(210, 26);
            this.btnShutdownInstant.TabIndex = 3;
            this.btnShutdownInstant.Text = "Herunterfahren";
            this.btnShutdownInstant.UseVisualStyleBackColor = true;
            this.btnShutdownInstant.Click += new System.EventHandler(this.btnShutdownInstant_Click);
            // 
            // btnShutdownAbort
            // 
            this.btnShutdownAbort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdownAbort.Location = new System.Drawing.Point(0, 138);
            this.btnShutdownAbort.Name = "btnShutdownAbort";
            this.btnShutdownAbort.Size = new System.Drawing.Size(210, 26);
            this.btnShutdownAbort.TabIndex = 2;
            this.btnShutdownAbort.Text = "Herunterfahren abbrechen";
            this.btnShutdownAbort.UseVisualStyleBackColor = true;
            this.btnShutdownAbort.Click += new System.EventHandler(this.btnShutdownAbort_Click);
            // 
            // btnHibernate
            // 
            this.btnHibernate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHibernate.Location = new System.Drawing.Point(0, 234);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(210, 26);
            this.btnHibernate.TabIndex = 4;
            this.btnHibernate.Text = "Ruhezustand";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStandby.Location = new System.Drawing.Point(0, 202);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(210, 26);
            this.btnStandby.TabIndex = 5;
            this.btnStandby.Text = "Energiesparmodus";
            this.btnStandby.UseVisualStyleBackColor = true;
            this.btnStandby.Click += new System.EventHandler(this.btnStandby_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Location = new System.Drawing.Point(0, 266);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(210, 26);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Neustart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoff.Location = new System.Drawing.Point(0, 298);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(210, 26);
            this.btnLogoff.TabIndex = 7;
            this.btnLogoff.Text = "Abmelden";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnLock
            // 
            this.btnLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLock.Location = new System.Drawing.Point(0, 330);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(210, 26);
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "Sperren";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(0, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 26);
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
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnShutdownTimed);
            this.panel1.Controls.Add(this.btnLock);
            this.panel1.Controls.Add(this.btnShutdownInstant);
            this.panel1.Controls.Add(this.btnLogoff);
            this.panel1.Controls.Add(this.btnShutdownAbort);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnHibernate);
            this.panel1.Controls.Add(this.btnStandby);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 392);
            this.panel1.TabIndex = 10;
            // 
            // FShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 409);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FShutdownTimer";
            this.Text = "ShutdownTimer";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinues;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnShutdownTimed;
        private System.Windows.Forms.Button btnShutdownInstant;
        private System.Windows.Forms.Button btnShutdownAbort;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}

