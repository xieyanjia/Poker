namespace Poker
{
    partial class frmPicTest
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picTest = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // picTest
            // 
            this.picTest.Image = global::Poker.Properties.Resources.back;
            this.picTest.Location = new System.Drawing.Point(34, 27);
            this.picTest.Margin = new System.Windows.Forms.Padding(2);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(85, 115);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTest.TabIndex = 0;
            this.picTest.TabStop = false;
            this.picTest.Click += new System.EventHandler(this.picTest_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTest.Location = new System.Drawing.Point(139, 27);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 57);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "換牌";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNum.Location = new System.Drawing.Point(139, 96);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(88, 46);
            this.lblNum.TabIndex = 2;
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 181);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.picTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPicTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖片資源測試";
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblNum;
    }
}

