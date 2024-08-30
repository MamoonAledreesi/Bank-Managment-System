namespace Bank_Managment_System.Currencies
{
    partial class frmUpdateRatesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateRatesScreen));
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.grpCountryInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.lblCountryRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewRate = new System.Windows.Forms.TextBox();
            this.chkUpdateRate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCountryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(1, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(285, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 42);
            this.label1.TabIndex = 44;
            this.label1.Text = "Update Rates";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(167, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 36);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(23, 197);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(121, 20);
            this.txtCountryCode.TabIndex = 48;
            // 
            // grpCountryInfo
            // 
            this.grpCountryInfo.Controls.Add(this.lblCountryRate);
            this.grpCountryInfo.Controls.Add(this.lblCurrencyName);
            this.grpCountryInfo.Controls.Add(this.lblCountryCode);
            this.grpCountryInfo.Controls.Add(this.lblCountryName);
            this.grpCountryInfo.Controls.Add(this.label5);
            this.grpCountryInfo.Controls.Add(this.label4);
            this.grpCountryInfo.Controls.Add(this.label3);
            this.grpCountryInfo.Controls.Add(this.label2);
            this.grpCountryInfo.Location = new System.Drawing.Point(320, 234);
            this.grpCountryInfo.Name = "grpCountryInfo";
            this.grpCountryInfo.Size = new System.Drawing.Size(200, 111);
            this.grpCountryInfo.TabIndex = 50;
            this.grpCountryInfo.TabStop = false;
            this.grpCountryInfo.Text = "Country";
            this.grpCountryInfo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Currency Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rate(1$): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Code:";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(128, 16);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(0, 13);
            this.lblCountryName.TabIndex = 4;
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(128, 41);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(0, 13);
            this.lblCountryCode.TabIndex = 5;
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.Location = new System.Drawing.Point(128, 63);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(0, 13);
            this.lblCurrencyName.TabIndex = 6;
            // 
            // lblCountryRate
            // 
            this.lblCountryRate.AutoSize = true;
            this.lblCountryRate.Location = new System.Drawing.Point(128, 84);
            this.lblCountryRate.Name = "lblCountryRate";
            this.lblCountryRate.Size = new System.Drawing.Size(0, 13);
            this.lblCountryRate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(365, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "Update Rate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewRate
            // 
            this.txtNewRate.Location = new System.Drawing.Point(148, 250);
            this.txtNewRate.Name = "txtNewRate";
            this.txtNewRate.Size = new System.Drawing.Size(121, 20);
            this.txtNewRate.TabIndex = 52;
            this.txtNewRate.Visible = false;
            this.txtNewRate.TextChanged += new System.EventHandler(this.txtNewRate_TextChanged);
            // 
            // chkUpdateRate
            // 
            this.chkUpdateRate.AutoSize = true;
            this.chkUpdateRate.Location = new System.Drawing.Point(55, 252);
            this.chkUpdateRate.Name = "chkUpdateRate";
            this.chkUpdateRate.Size = new System.Drawing.Size(87, 17);
            this.chkUpdateRate.TabIndex = 53;
            this.chkUpdateRate.Text = "Update Rate";
            this.chkUpdateRate.UseVisualStyleBackColor = true;
            // 
            // frmUpdateRatesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkUpdateRate);
            this.Controls.Add(this.txtNewRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpCountryInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmUpdateRatesScreen";
            this.Text = "frmUpdateRatesScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCountryInfo.ResumeLayout(false);
            this.grpCountryInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.GroupBox grpCountryInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountryRate;
        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewRate;
        private System.Windows.Forms.CheckBox chkUpdateRate;
    }
}