namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblTotalAmountResult = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblBetAmountResult = new System.Windows.Forms.TextBox();
            this.grpButton.SuspendLayout();
            this.grpBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(36, 29);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(485, 160);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(36, 354);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(484, 106);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(101, 41);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(60, 37);
            this.btnChangeCard.TabIndex = 4;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(291, 41);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(163, 37);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(167, 41);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(98, 37);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(35, 41);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(60, 37);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpBet
            // 
            this.grpBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpBet.Controls.Add(this.lblBetAmountResult);
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.lblTotalAmountResult);
            this.grpBet.Controls.Add(this.lblBetAmount);
            this.grpBet.Controls.Add(this.lblTotalAmount);
            this.grpBet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBet.Location = new System.Drawing.Point(36, 214);
            this.grpBet.Name = "grpBet";
            this.grpBet.Size = new System.Drawing.Size(484, 117);
            this.grpBet.TabIndex = 2;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(409, 44);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(60, 37);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblTotalAmountResult
            // 
            this.lblTotalAmountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmountResult.Location = new System.Drawing.Point(80, 49);
            this.lblTotalAmountResult.Name = "lblTotalAmountResult";
            this.lblTotalAmountResult.Size = new System.Drawing.Size(114, 31);
            this.lblTotalAmountResult.TabIndex = 2;
            this.lblTotalAmountResult.Text = "1000000";
            this.lblTotalAmountResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(200, 54);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(74, 21);
            this.lblBetAmount.TabIndex = 1;
            this.lblBetAmount.Text = "押注金額";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(16, 52);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(58, 21);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "總資金";
            // 
            // lblBetAmountResult
            // 
            this.lblBetAmountResult.Location = new System.Drawing.Point(280, 49);
            this.lblBetAmountResult.Name = "lblBetAmountResult";
            this.lblBetAmountResult.Size = new System.Drawing.Size(112, 29);
            this.lblBetAmountResult.TabIndex = 5;
            this.lblBetAmountResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(554, 496);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.grpButton.ResumeLayout(false);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblTotalAmountResult;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox lblBetAmountResult;
    }
}