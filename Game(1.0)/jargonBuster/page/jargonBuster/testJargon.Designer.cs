namespace jargonBuster.page
{
    partial class testJargon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testJargon));
            this.pcbPowerOff = new System.Windows.Forms.PictureBox();
            this.pcbVoice = new System.Windows.Forms.PictureBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblResultMean = new System.Windows.Forms.Label();
            this.lblResultTitleR = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlNotSucces = new System.Windows.Forms.Panel();
            this.btnNotNext = new System.Windows.Forms.Button();
            this.lblNotSucces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoice)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.pnlNotSucces.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbPowerOff
            // 
            this.pcbPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("pcbPowerOff.Image")));
            this.pcbPowerOff.Location = new System.Drawing.Point(345, 3);
            this.pcbPowerOff.Name = "pcbPowerOff";
            this.pcbPowerOff.Size = new System.Drawing.Size(32, 32);
            this.pcbPowerOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPowerOff.TabIndex = 3;
            this.pcbPowerOff.TabStop = false;
            this.pcbPowerOff.Click += new System.EventHandler(this.pcbPowerOff_Click);
            // 
            // pcbVoice
            // 
            this.pcbVoice.Image = ((System.Drawing.Image)(resources.GetObject("pcbVoice.Image")));
            this.pcbVoice.Location = new System.Drawing.Point(139, 78);
            this.pcbVoice.Name = "pcbVoice";
            this.pcbVoice.Size = new System.Drawing.Size(100, 100);
            this.pcbVoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVoice.TabIndex = 4;
            this.pcbVoice.TabStop = false;
            this.pcbVoice.Click += new System.EventHandler(this.pcbVoice_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblResultMean);
            this.pnlResult.Controls.Add(this.lblResultTitleR);
            this.pnlResult.Controls.Add(this.btnNext);
            this.pnlResult.Controls.Add(this.lblResultTitle);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Location = new System.Drawing.Point(34, 228);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(304, 308);
            this.pnlResult.TabIndex = 10;
            this.pnlResult.Visible = false;
            // 
            // lblResultMean
            // 
            this.lblResultMean.AutoSize = true;
            this.lblResultMean.Location = new System.Drawing.Point(28, 173);
            this.lblResultMean.Name = "lblResultMean";
            this.lblResultMean.Size = new System.Drawing.Size(78, 17);
            this.lblResultMean.TabIndex = 11;
            this.lblResultMean.Text = "resultMean";
            // 
            // lblResultTitleR
            // 
            this.lblResultTitleR.AutoSize = true;
            this.lblResultTitleR.Font = new System.Drawing.Font("Palatino Linotype", 9.7F);
            this.lblResultTitleR.Location = new System.Drawing.Point(46, 60);
            this.lblResultTitleR.Name = "lblResultTitleR";
            this.lblResultTitleR.Size = new System.Drawing.Size(208, 23);
            this.lblResultTitleR.TabIndex = 10;
            this.lblResultTitleR.Text = "FOR AND ITS MEANING ";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNext.Location = new System.Drawing.Point(83, 251);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 54);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Palatino Linotype", 9.7F);
            this.lblResultTitle.Location = new System.Drawing.Point(13, 26);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(272, 23);
            this.lblResultTitle.TabIndex = 2;
            this.lblResultTitle.Text = " THE WORD YOU ARE LOOKING ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(28, 135);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "result";
            // 
            // pnlNotSucces
            // 
            this.pnlNotSucces.Controls.Add(this.btnNotNext);
            this.pnlNotSucces.Controls.Add(this.lblNotSucces);
            this.pnlNotSucces.Location = new System.Drawing.Point(36, 229);
            this.pnlNotSucces.Name = "pnlNotSucces";
            this.pnlNotSucces.Size = new System.Drawing.Size(302, 230);
            this.pnlNotSucces.TabIndex = 13;
            this.pnlNotSucces.Visible = false;
            // 
            // btnNotNext
            // 
            this.btnNotNext.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNotNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotNext.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotNext.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNotNext.Location = new System.Drawing.Point(85, 130);
            this.btnNotNext.Name = "btnNotNext";
            this.btnNotNext.Size = new System.Drawing.Size(122, 54);
            this.btnNotNext.TabIndex = 9;
            this.btnNotNext.Text = "Next";
            this.btnNotNext.UseVisualStyleBackColor = false;
            this.btnNotNext.Click += new System.EventHandler(this.btnNotNext_Click);
            // 
            // lblNotSucces
            // 
            this.lblNotSucces.AutoSize = true;
            this.lblNotSucces.Font = new System.Drawing.Font("Palatino Linotype", 9.7F);
            this.lblNotSucces.Location = new System.Drawing.Point(54, 36);
            this.lblNotSucces.Name = "lblNotSucces";
            this.lblNotSucces.Size = new System.Drawing.Size(198, 23);
            this.lblNotSucces.TabIndex = 3;
            this.lblNotSucces.Text = "Spoken Word Not Found";
            // 
            // testJargon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.pcbVoice);
            this.Controls.Add(this.pcbPowerOff);
            this.Controls.Add(this.pnlNotSucces);
            this.Controls.Add(this.pnlResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "testJargon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "testJargon";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoice)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlNotSucces.ResumeLayout(false);
            this.pnlNotSucces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPowerOff;
        private System.Windows.Forms.PictureBox pcbVoice;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultTitleR;
        private System.Windows.Forms.Label lblResultMean;
        private System.Windows.Forms.Panel pnlNotSucces;
        private System.Windows.Forms.Button btnNotNext;
        private System.Windows.Forms.Label lblNotSucces;
    }
}