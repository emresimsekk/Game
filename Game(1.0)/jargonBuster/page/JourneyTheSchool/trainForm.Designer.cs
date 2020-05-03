namespace jargonBuster.page.JourneyTheSchool
{
    partial class trainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainForm));
            this.pcbPowerOff = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPowerOff
            // 
            this.pcbPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("pcbPowerOff.Image")));
            this.pcbPowerOff.Location = new System.Drawing.Point(347, 1);
            this.pcbPowerOff.Name = "pcbPowerOff";
            this.pcbPowerOff.Size = new System.Drawing.Size(32, 32);
            this.pcbPowerOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPowerOff.TabIndex = 3;
            this.pcbPowerOff.TabStop = false;
            this.pcbPowerOff.Click += new System.EventHandler(this.pcbPowerOff_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(6, 72);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(370, 483);
            this.pnlContent.TabIndex = 6;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTest.Location = new System.Drawing.Point(246, 574);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(122, 54);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // trainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 640);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pcbPowerOff);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trainForm";
            this.Load += new System.EventHandler(this.trainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPowerOff;
        private System.Windows.Forms.FlowLayoutPanel pnlContent;
        private System.Windows.Forms.Button btnTest;
    }
}