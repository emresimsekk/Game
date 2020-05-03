namespace jargonBuster.page
{
    partial class trainJargon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainJargon));
            this.pcbVoice = new System.Windows.Forms.PictureBox();
            this.pcbPowerOff = new System.Windows.Forms.PictureBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.rtMeaning = new System.Windows.Forms.RichTextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlSucces = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSucces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.pnlSucces.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbVoice
            // 
            this.pcbVoice.Image = ((System.Drawing.Image)(resources.GetObject("pcbVoice.Image")));
            this.pcbVoice.Location = new System.Drawing.Point(139, 78);
            this.pcbVoice.Name = "pcbVoice";
            this.pcbVoice.Size = new System.Drawing.Size(100, 100);
            this.pcbVoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVoice.TabIndex = 1;
            this.pcbVoice.TabStop = false;
            this.pcbVoice.Click += new System.EventHandler(this.pcbVoice_Click);
            // 
            // pcbPowerOff
            // 
            this.pcbPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("pcbPowerOff.Image")));
            this.pcbPowerOff.Location = new System.Drawing.Point(345, 3);
            this.pcbPowerOff.Name = "pcbPowerOff";
            this.pcbPowerOff.Size = new System.Drawing.Size(32, 32);
            this.pcbPowerOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPowerOff.TabIndex = 2;
            this.pcbPowerOff.TabStop = false;
            this.pcbPowerOff.Click += new System.EventHandler(this.pcbPowerOff_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblError);
            this.pnlResult.Controls.Add(this.rtMeaning);
            this.pnlResult.Controls.Add(this.btnNo);
            this.pnlResult.Controls.Add(this.btnYes);
            this.pnlResult.Controls.Add(this.lblResultTitle);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Location = new System.Drawing.Point(34, 228);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(304, 308);
            this.pnlResult.TabIndex = 9;
            this.pnlResult.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(3, 136);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(165, 17);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Please fill in the meaning";
            this.lblError.Visible = false;
            // 
            // rtMeaning
            // 
            this.rtMeaning.Location = new System.Drawing.Point(3, 166);
            this.rtMeaning.Name = "rtMeaning";
            this.rtMeaning.Size = new System.Drawing.Size(298, 54);
            this.rtMeaning.TabIndex = 10;
            this.rtMeaning.Text = "";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.btnNo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNo.Location = new System.Drawing.Point(177, 250);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(122, 54);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnYes.Location = new System.Drawing.Point(2, 250);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(122, 54);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Palatino Linotype", 9.7F);
            this.lblResultTitle.Location = new System.Drawing.Point(23, 25);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(254, 23);
            this.lblResultTitle.TabIndex = 2;
            this.lblResultTitle.Text = "THE VOCABULARY YOU SAY ?";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 83);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "result";
            // 
            // pnlSucces
            // 
            this.pnlSucces.Controls.Add(this.btnNext);
            this.pnlSucces.Controls.Add(this.lblSucces);
            this.pnlSucces.Location = new System.Drawing.Point(35, 231);
            this.pnlSucces.Name = "pnlSucces";
            this.pnlSucces.Size = new System.Drawing.Size(302, 230);
            this.pnlSucces.TabIndex = 12;
            this.pnlSucces.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNext.Location = new System.Drawing.Point(85, 130);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 54);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Palatino Linotype", 9.7F);
            this.lblSucces.Location = new System.Drawing.Point(7, 36);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(283, 23);
            this.lblSucces.TabIndex = 3;
            this.lblSucces.Text = "MODEL SUCCESSFULLY TRAINED";
            // 
            // trainJargon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.pnlSucces);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pcbPowerOff);
            this.Controls.Add(this.pcbVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trainJargon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trainJargon";
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlSucces.ResumeLayout(false);
            this.pnlSucces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbVoice;
        private System.Windows.Forms.PictureBox pcbPowerOff;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RichTextBox rtMeaning;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel pnlSucces;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSucces;
    }
}