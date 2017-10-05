namespace WindowsFormsApp3
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
            this.digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.nCalendarControl1 = new Nevron.Nov.WinFormControls.NCalendarControl();
            this.SuspendLayout();
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.DisplayRecordIndex = 0;
            this.digitalGauge1.Location = new System.Drawing.Point(144, 56);
            this.digitalGauge1.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge1.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Size = new System.Drawing.Size(253, 180);
            this.digitalGauge1.TabIndex = 0;
            // 
            // nCalendarControl1
            // 
            this.nCalendarControl1.AutoSize = false;
            this.nCalendarControl1.DesignTimeState = null;
            this.nCalendarControl1.Location = new System.Drawing.Point(102, 284);
            this.nCalendarControl1.Name = "nCalendarControl1";
            this.nCalendarControl1.Size = new System.Drawing.Size(382, 243);
            this.nCalendarControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 574);
            this.Controls.Add(this.nCalendarControl1);
            this.Controls.Add(this.digitalGauge1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private Nevron.Nov.WinFormControls.NCalendarControl nCalendarControl1;
    }
}

