namespace Bank_Managment_System
{
    partial class frmLoginRegisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginRegisters));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewLoginRegisters = new System.Windows.Forms.DataGridView();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanAccessClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanAccessTransactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanAccessManageUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(292, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login Registers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewLoginRegisters
            // 
            this.dataGridViewLoginRegisters.AllowUserToAddRows = false;
            this.dataGridViewLoginRegisters.AllowUserToDeleteRows = false;
            this.dataGridViewLoginRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginRegisters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.Username,
            this.Password,
            this.CanAccessClients,
            this.CanAccessTransactions,
            this.CanAccessManageUsers});
            this.dataGridViewLoginRegisters.Location = new System.Drawing.Point(-1, 213);
            this.dataGridViewLoginRegisters.Name = "dataGridViewLoginRegisters";
            this.dataGridViewLoginRegisters.ReadOnly = true;
            this.dataGridViewLoginRegisters.Size = new System.Drawing.Size(800, 150);
            this.dataGridViewLoginRegisters.TabIndex = 10;
            this.dataGridViewLoginRegisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoginRegisters_CellContentClick);
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTime.HeaderText = "DateTime";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 80;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // CanAccessClients
            // 
            this.CanAccessClients.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CanAccessClients.HeaderText = "CanAccessClients";
            this.CanAccessClients.Name = "CanAccessClients";
            this.CanAccessClients.ReadOnly = true;
            // 
            // CanAccessTransactions
            // 
            this.CanAccessTransactions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CanAccessTransactions.HeaderText = "CanAccessTransactions";
            this.CanAccessTransactions.Name = "CanAccessTransactions";
            this.CanAccessTransactions.ReadOnly = true;
            // 
            // CanAccessManageUsers
            // 
            this.CanAccessManageUsers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CanAccessManageUsers.HeaderText = "CanAccessManageUsers";
            this.CanAccessManageUsers.Name = "CanAccessManageUsers";
            this.CanAccessManageUsers.ReadOnly = true;
            // 
            // frmLoginRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLoginRegisters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLoginRegisters";
            this.Text = "Login Registers";
            this.Load += new System.EventHandler(this.frmLoginRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginRegisters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewLoginRegisters;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanAccessClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanAccessTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanAccessManageUsers;
    }
}