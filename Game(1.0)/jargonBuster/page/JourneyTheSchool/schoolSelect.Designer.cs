namespace jargonBuster.page.JourneyTheSchool
{
    partial class schoolSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schoolSelect));
            this.pcbPowerOff = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPowerOff
            // 
            this.pcbPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("pcbPowerOff.Image")));
            this.pcbPowerOff.Location = new System.Drawing.Point(347, 1);
            this.pcbPowerOff.Name = "pcbPowerOff";
            this.pcbPowerOff.Size = new System.Drawing.Size(32, 32);
            this.pcbPowerOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPowerOff.TabIndex = 2;
            this.pcbPowerOff.TabStop = false;
            this.pcbPowerOff.Click += new System.EventHandler(this.pcbPowerOff_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlHeader.Controls.Add(this.pcbLogo);
            this.pnlHeader.Controls.Add(this.pcbPowerOff);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(380, 271);
            this.pnlHeader.TabIndex = 3;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(116, 51);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(150, 150);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 3;
            this.pcbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 9.7F);
            this.lblTitle.Location = new System.Drawing.Point(12, 329);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 23);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "WOULD YOU LIKE TO TRAIN THE MODEL ?";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.btnNo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNo.Location = new System.Drawing.Point(214, 455);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(122, 54);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnYes.Location = new System.Drawing.Point(39, 455);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(122, 54);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // schoolSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "schoolSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "schoolSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPowerOff;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
    }
}