namespace Bank_Managment_System.Transactions
{
    partial class frmTransferScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferScreen));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFromClientInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfromTotalBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfromLastName = new System.Windows.Forms.TextBox();
            this.txtfromFirstName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtFromAccountNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToAccountNumber = new System.Windows.Forms.TextBox();
            this.gbToClientInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToTotalBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToLastName = new System.Windows.Forms.TextBox();
            this.txtToFirstName = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbFromClientInfo.SuspendLayout();
            this.gbToClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(292, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Transfer ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbFromClientInfo
            // 
            this.gbFromClientInfo.Controls.Add(this.label7);
            this.gbFromClientInfo.Controls.Add(this.txtfromTotalBalance);
            this.gbFromClientInfo.Controls.Add(this.label3);
            this.gbFromClientInfo.Controls.Add(this.label2);
            this.gbFromClientInfo.Controls.Add(this.txtfromLastName);
            this.gbFromClientInfo.Controls.Add(this.txtfromFirstName);
            this.gbFromClientInfo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFromClientInfo.Location = new System.Drawing.Point(12, 269);
            this.gbFromClientInfo.Name = "gbFromClientInfo";
            this.gbFromClientInfo.Size = new System.Drawing.Size(292, 151);
            this.gbFromClientInfo.TabIndex = 24;
            this.gbFromClientInfo.TabStop = false;
            this.gbFromClientInfo.Text = "Client Informaton";
            this.gbFromClientInfo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Total Balance";
            // 
            // txtfromTotalBalance
            // 
            this.txtfromTotalBalance.Location = new System.Drawing.Point(110, 106);
            this.txtfromTotalBalance.Name = "txtfromTotalBalance";
            this.txtfromTotalBalance.ReadOnly = true;
            this.txtfromTotalBalance.Size = new System.Drawing.Size(173, 20);
            this.txtfromTotalBalance.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // txtfromLastName
            // 
            this.txtfromLastName.Location = new System.Drawing.Point(110, 66);
            this.txtfromLastName.Name = "txtfromLastName";
            this.txtfromLastName.ReadOnly = true;
            this.txtfromLastName.Size = new System.Drawing.Size(173, 20);
            this.txtfromLastName.TabIndex = 1;
            // 
            // txtfromFirstName
            // 
            this.txtfromFirstName.Location = new System.Drawing.Point(110, 22);
            this.txtfromFirstName.Name = "txtfromFirstName";
            this.txtfromFirstName.ReadOnly = true;
            this.txtfromFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtfromFirstName.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 161);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(241, 16);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Account number to trnsfer from";
            // 
            // txtFromAccountNumber
            // 
            this.txtFromAccountNumber.Location = new System.Drawing.Point(60, 191);
            this.txtFromAccountNumber.Name = "txtFromAccountNumber";
            this.txtFromAccountNumber.Size = new System.Drawing.Size(120, 20);
            this.txtFromAccountNumber.TabIndex = 0;
            this.txtFromAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromAccountNumber_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Account number to trnsfer to";
            this.label4.Visible = false;
            // 
            // txtToAccountNumber
            // 
            this.txtToAccountNumber.Location = new System.Drawing.Point(537, 191);
            this.txtToAccountNumber.Name = "txtToAccountNumber";
            this.txtToAccountNumber.Size = new System.Drawing.Size(120, 20);
            this.txtToAccountNumber.TabIndex = 1;
            this.txtToAccountNumber.Visible = false;
            this.txtToAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToAccountNumber_KeyDown);
            // 
            // gbToClientInfo
            // 
            this.gbToClientInfo.Controls.Add(this.label5);
            this.gbToClientInfo.Controls.Add(this.txtToTotalBalance);
            this.gbToClientInfo.Controls.Add(this.label6);
            this.gbToClientInfo.Controls.Add(this.label8);
            this.gbToClientInfo.Controls.Add(this.txtToLastName);
            this.gbToClientInfo.Controls.Add(this.txtToFirstName);
            this.gbToClientInfo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToClientInfo.Location = new System.Drawing.Point(489, 269);
            this.gbToClientInfo.Name = "gbToClientInfo";
            this.gbToClientInfo.Size = new System.Drawing.Size(292, 151);
            this.gbToClientInfo.TabIndex = 29;
            this.gbToClientInfo.TabStop = false;
            this.gbToClientInfo.Text = "Client Informaton";
            this.gbToClientInfo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Balance";
            // 
            // txtToTotalBalance
            // 
            this.txtToTotalBalance.Location = new System.Drawing.Point(110, 106);
            this.txtToTotalBalance.Name = "txtToTotalBalance";
            this.txtToTotalBalance.ReadOnly = true;
            this.txtToTotalBalance.Size = new System.Drawing.Size(173, 20);
            this.txtToTotalBalance.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "First Name";
            // 
            // txtToLastName
            // 
            this.txtToLastName.Location = new System.Drawing.Point(110, 66);
            this.txtToLastName.Name = "txtToLastName";
            this.txtToLastName.ReadOnly = true;
            this.txtToLastName.Size = new System.Drawing.Size(173, 20);
            this.txtToLastName.TabIndex = 1;
            // 
            // txtToFirstName
            // 
            this.txtToFirstName.Location = new System.Drawing.Point(110, 22);
            this.txtToFirstName.Name = "txtToFirstName";
            this.txtToFirstName.ReadOnly = true;
            this.txtToFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtToFirstName.TabIndex = 0;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Teal;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(336, 310);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(120, 45);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(336, 269);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(120, 20);
            this.txtTransferAmount.TabIndex = 2;
            this.txtTransferAmount.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Transfer amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(3, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTransferScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToAccountNumber);
            this.Controls.Add(this.gbToClientInfo);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtFromAccountNumber);
            this.Controls.Add(this.gbFromClientInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransferScreen";
            this.Text = "Transfer Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbFromClientInfo.ResumeLayout(false);
            this.gbFromClientInfo.PerformLayout();
            this.gbToClientInfo.ResumeLayout(false);
            this.gbToClientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFromClientInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfromLastName;
        private System.Windows.Forms.TextBox txtfromFirstName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtFromAccountNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfromTotalBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToAccountNumber;
        private System.Windows.Forms.GroupBox gbToClientInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToTotalBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToLastName;
        private System.Windows.Forms.TextBox txtToFirstName;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
    }
}