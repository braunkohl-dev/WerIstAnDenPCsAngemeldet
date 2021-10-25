
namespace cs_wf_AngemeldeteBenutzerAuslesen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxErg = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxConf = new System.Windows.Forms.TextBox();
            this.buttonConfigSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxErg
            // 
            this.textBoxErg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErg.Location = new System.Drawing.Point(12, 162);
            this.textBoxErg.Multiline = true;
            this.textBoxErg.Name = "textBoxErg";
            this.textBoxErg.ReadOnly = true;
            this.textBoxErg.Size = new System.Drawing.Size(868, 318);
            this.textBoxErg.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStart.Location = new System.Drawing.Point(12, 509);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(255, 57);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Abfrage starten";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxConf
            // 
            this.textBoxConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConf.Location = new System.Drawing.Point(12, 32);
            this.textBoxConf.Multiline = true;
            this.textBoxConf.Name = "textBoxConf";
            this.textBoxConf.Size = new System.Drawing.Size(868, 71);
            this.textBoxConf.TabIndex = 2;
            this.textBoxConf.Text = "PC-1;PC-2;PC-3;PC-4;PC-5";
            // 
            // buttonConfigSave
            // 
            this.buttonConfigSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConfigSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonConfigSave.Location = new System.Drawing.Point(12, 109);
            this.buttonConfigSave.Name = "buttonConfigSave";
            this.buttonConfigSave.Size = new System.Drawing.Size(255, 39);
            this.buttonConfigSave.TabIndex = 3;
            this.buttonConfigSave.Text = "Konfiguration sichern";
            this.buttonConfigSave.UseVisualStyleBackColor = false;
            this.buttonConfigSave.Click += new System.EventHandler(this.buttonConfigSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonExit.Location = new System.Drawing.Point(625, 509);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(255, 57);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "beenden";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(893, 600);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConfigSave);
            this.Controls.Add(this.textBoxConf);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxErg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wer ist angemeldet?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxErg;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxConf;
        private System.Windows.Forms.Button buttonConfigSave;
        private System.Windows.Forms.Button buttonExit;
    }
}

