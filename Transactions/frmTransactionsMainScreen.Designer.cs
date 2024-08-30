namespace Bank_Managment_System.Transactions
{
    partial class frmTransactionsMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionsMainScreen));
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrow = new System.Windows.Forms.Button();
            this.btnTotalBalances = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTransferLog = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(311, 156);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(175, 38);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrow
            // 
            this.btnWithdrow.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrow.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdrow.Image")));
            this.btnWithdrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrow.Location = new System.Drawing.Point(311, 211);
            this.btnWithdrow.Name = "btnWithdrow";
            this.btnWithdrow.Size = new System.Drawing.Size(175, 38);
            this.btnWithdrow.TabIndex = 1;
            this.btnWithdrow.Text = "Withdrow";
            this.btnWithdrow.UseVisualStyleBackColor = true;
            this.btnWithdrow.Click += new System.EventHandler(this.btnWithdrow_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBalances.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalBalances.Image")));
            this.btnTotalBalances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalBalances.Location = new System.Drawing.Point(311, 266);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Size = new System.Drawing.Size(175, 38);
            this.btnTotalBalances.TabIndex = 2;
            this.btnTotalBalances.Text = "Total Balances";
            this.btnTotalBalances.UseVisualStyleBackColor = true;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(311, 321);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(175, 38);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferLog.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferLog.Image")));
            this.btnTransferLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransferLog.Location = new System.Drawing.Point(311, 376);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Size = new System.Drawing.Size(175, 38);
            this.btnTransferLog.TabIndex = 4;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.UseVisualStyleBackColor = true;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(306, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Transactions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmTransactionsMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(752, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransferLog);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnTotalBalances);
            this.Controls.Add(this.btnWithdrow);
            this.Controls.Add(this.btnDeposit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransactionsMainScreen";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrow;
        private System.Windows.Forms.Button btnTotalBalances;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnTransferLog;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}