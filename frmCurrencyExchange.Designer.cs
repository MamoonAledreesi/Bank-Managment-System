namespace Bank_Managment_System
{
    partial class frmcurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcurrencyExchange));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCurrencyCalculater = new System.Windows.Forms.Button();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.btnFindCurrency = new System.Windows.Forms.Button();
            this.btnListCrrencies = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(256, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Currency Excahnge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCurrencyCalculater
            // 
            this.btnCurrencyCalculater.Enabled = false;
            this.btnCurrencyCalculater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencyCalculater.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrencyCalculater.Image")));
            this.btnCurrencyCalculater.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrencyCalculater.Location = new System.Drawing.Point(295, 348);
            this.btnCurrencyCalculater.Name = "btnCurrencyCalculater";
            this.btnCurrencyCalculater.Size = new System.Drawing.Size(196, 44);
            this.btnCurrencyCalculater.TabIndex = 15;
            this.btnCurrencyCalculater.Text = "Currency Calculater";
            this.btnCurrencyCalculater.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Enabled = false;
            this.btnUpdateRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRate.Image")));
            this.btnUpdateRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRate.Location = new System.Drawing.Point(295, 288);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(196, 44);
            this.btnUpdateRate.TabIndex = 14;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // btnFindCurrency
            // 
            this.btnFindCurrency.Enabled = false;
            this.btnFindCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCurrency.Image")));
            this.btnFindCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCurrency.Location = new System.Drawing.Point(295, 227);
            this.btnFindCurrency.Name = "btnFindCurrency";
            this.btnFindCurrency.Size = new System.Drawing.Size(196, 44);
            this.btnFindCurrency.TabIndex = 13;
            this.btnFindCurrency.Text = "Find Currency";
            this.btnFindCurrency.UseVisualStyleBackColor = true;
            this.btnFindCurrency.Click += new System.EventHandler(this.btnFindCurrency_Click);
            // 
            // btnListCrrencies
            // 
            this.btnListCrrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCrrencies.Image = ((System.Drawing.Image)(resources.GetObject("btnListCrrencies.Image")));
            this.btnListCrrencies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCrrencies.Location = new System.Drawing.Point(295, 167);
            this.btnListCrrencies.Name = "btnListCrrencies";
            this.btnListCrrencies.Size = new System.Drawing.Size(196, 44);
            this.btnListCrrencies.TabIndex = 12;
            this.btnListCrrencies.Text = "List Crrencies";
            this.btnListCrrencies.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmcurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCurrencyCalculater);
            this.Controls.Add(this.btnUpdateRate);
            this.Controls.Add(this.btnFindCurrency);
            this.Controls.Add(this.btnListCrrencies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Exchange";
            this.Load += new System.EventHandler(this.frmcurrencyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCurrencyCalculater;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.Button btnFindCurrency;
        private System.Windows.Forms.Button btnListCrrencies;
        private System.Windows.Forms.Button btnBack;
    }
}