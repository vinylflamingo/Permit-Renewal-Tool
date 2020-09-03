namespace CW_EZ_Renewals
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.listCountLabel = new System.Windows.Forms.Label();
            this.acctNumberLabel = new System.Windows.Forms.Label();
            this.acctNameLabel = new System.Windows.Forms.Label();
            this.acctNumberValue = new System.Windows.Forms.Label();
            this.acctNameValue = new System.Windows.Forms.Label();
            this.listCountValue = new System.Windows.Forms.Label();
            this.acctAddressLabel = new System.Windows.Forms.Label();
            this.acctAddressValue = new System.Windows.Forms.Label();
            this.acctNRFlag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.renewActiveBtn = new System.Windows.Forms.Button();
            this.renewNRNPBtn = new System.Windows.Forms.Button();
            this.outstandingBalanceValue = new System.Windows.Forms.Label();
            this.loadAcctsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCountLabel
            // 
            this.listCountLabel.AutoSize = true;
            this.listCountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCountLabel.Location = new System.Drawing.Point(235, 10);
            this.listCountLabel.Name = "listCountLabel";
            this.listCountLabel.Size = new System.Drawing.Size(61, 18);
            this.listCountLabel.TabIndex = 0;
            this.listCountLabel.Text = "Count:";
            // 
            // acctNumberLabel
            // 
            this.acctNumberLabel.AutoSize = true;
            this.acctNumberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNumberLabel.Location = new System.Drawing.Point(11, 9);
            this.acctNumberLabel.Name = "acctNumberLabel";
            this.acctNumberLabel.Size = new System.Drawing.Size(152, 18);
            this.acctNumberLabel.TabIndex = 0;
            this.acctNumberLabel.Text = "Account Number: ";
            // 
            // acctNameLabel
            // 
            this.acctNameLabel.AutoSize = true;
            this.acctNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNameLabel.Location = new System.Drawing.Point(11, 51);
            this.acctNameLabel.Name = "acctNameLabel";
            this.acctNameLabel.Size = new System.Drawing.Size(59, 18);
            this.acctNameLabel.TabIndex = 0;
            this.acctNameLabel.Text = "Name:";
            // 
            // acctNumberValue
            // 
            this.acctNumberValue.AutoSize = true;
            this.acctNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNumberValue.Location = new System.Drawing.Point(11, 29);
            this.acctNumberValue.Name = "acctNumberValue";
            this.acctNumberValue.Size = new System.Drawing.Size(63, 20);
            this.acctNumberValue.TabIndex = 1;
            this.acctNumberValue.Text = "000000";
            // 
            // acctNameValue
            // 
            this.acctNameValue.AutoSize = true;
            this.acctNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNameValue.Location = new System.Drawing.Point(11, 71);
            this.acctNameValue.Name = "acctNameValue";
            this.acctNameValue.Size = new System.Drawing.Size(88, 20);
            this.acctNameValue.TabIndex = 1;
            this.acctNameValue.Text = "ABCDEFG";
            // 
            // listCountValue
            // 
            this.listCountValue.AutoSize = true;
            this.listCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCountValue.Location = new System.Drawing.Point(302, 10);
            this.listCountValue.Name = "listCountValue";
            this.listCountValue.Size = new System.Drawing.Size(49, 20);
            this.listCountValue.TabIndex = 1;
            this.listCountValue.Text = "00/00";
            // 
            // acctAddressLabel
            // 
            this.acctAddressLabel.AutoSize = true;
            this.acctAddressLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctAddressLabel.Location = new System.Drawing.Point(11, 93);
            this.acctAddressLabel.Name = "acctAddressLabel";
            this.acctAddressLabel.Size = new System.Drawing.Size(80, 18);
            this.acctAddressLabel.TabIndex = 0;
            this.acctAddressLabel.Text = "Address:";
            // 
            // acctAddressValue
            // 
            this.acctAddressValue.AutoSize = true;
            this.acctAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctAddressValue.Location = new System.Drawing.Point(11, 113);
            this.acctAddressValue.Name = "acctAddressValue";
            this.acctAddressValue.Size = new System.Drawing.Size(88, 20);
            this.acctAddressValue.TabIndex = 1;
            this.acctAddressValue.Text = "ABCDEFG";
            // 
            // acctNRFlag
            // 
            this.acctNRFlag.AutoSize = true;
            this.acctNRFlag.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.acctNRFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acctNRFlag.Location = new System.Drawing.Point(40, 195);
            this.acctNRFlag.MinimumSize = new System.Drawing.Size(40, 40);
            this.acctNRFlag.Name = "acctNRFlag";
            this.acctNRFlag.Size = new System.Drawing.Size(40, 40);
            this.acctNRFlag.TabIndex = 3;
            this.acctNRFlag.Text = "NR";
            this.acctNRFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outstanding Balance:";
            // 
            // renewActiveBtn
            // 
            this.renewActiveBtn.Location = new System.Drawing.Point(103, 194);
            this.renewActiveBtn.Name = "renewActiveBtn";
            this.renewActiveBtn.Size = new System.Drawing.Size(110, 43);
            this.renewActiveBtn.TabIndex = 4;
            this.renewActiveBtn.Text = "Renew \r\nStatus: Active\r\n";
            this.renewActiveBtn.UseVisualStyleBackColor = true;
            this.renewActiveBtn.Click += new System.EventHandler(this.renewActiveBtn_Click);
            this.renewActiveBtn.Hide();
            // 
            // renewNRNPBtn
            // 
            this.renewNRNPBtn.Location = new System.Drawing.Point(236, 194);
            this.renewNRNPBtn.Name = "renewNRNPBtn";
            this.renewNRNPBtn.Size = new System.Drawing.Size(110, 43);
            this.renewNRNPBtn.TabIndex = 4;
            this.renewNRNPBtn.Text = "Renew \r\nStatus:NR NP";
            this.renewNRNPBtn.UseVisualStyleBackColor = true;
            this.renewNRNPBtn.Click += new System.EventHandler(this.renewNRNPBtn_Click);
            this.renewNRNPBtn.Hide();
            // 
            // outstandingBalanceValue
            // 
            this.outstandingBalanceValue.AutoSize = true;
            this.outstandingBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outstandingBalanceValue.Location = new System.Drawing.Point(11, 155);
            this.outstandingBalanceValue.Name = "outstandingBalanceValue";
            this.outstandingBalanceValue.Size = new System.Drawing.Size(63, 20);
            this.outstandingBalanceValue.TabIndex = 1;
            this.outstandingBalanceValue.Text = "000000";
            // 
            // loadAcctsBtn
            // 
            this.loadAcctsBtn.Location = new System.Drawing.Point(236, 33);
            this.loadAcctsBtn.Name = "loadAcctsBtn";
            this.loadAcctsBtn.Size = new System.Drawing.Size(88, 22);
            this.loadAcctsBtn.TabIndex = 4;
            this.loadAcctsBtn.Text = "Load Accounts";
            this.loadAcctsBtn.UseVisualStyleBackColor = true;
            this.loadAcctsBtn.Click += new System.EventHandler(this.loadAcctsBtn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 281);
            this.Controls.Add(this.renewNRNPBtn);
            this.Controls.Add(this.loadAcctsBtn);
            this.Controls.Add(this.renewActiveBtn);
            this.Controls.Add(this.acctNRFlag);
            this.Controls.Add(this.acctAddressValue);
            this.Controls.Add(this.acctNameValue);
            this.Controls.Add(this.listCountValue);
            this.Controls.Add(this.outstandingBalanceValue);
            this.Controls.Add(this.acctNumberValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acctAddressLabel);
            this.Controls.Add(this.acctNameLabel);
            this.Controls.Add(this.acctNumberLabel);
            this.Controls.Add(this.listCountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryWolf EZ Renewals - NOLA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listCountLabel;
        private System.Windows.Forms.Label acctNumberLabel;
        private System.Windows.Forms.Label acctNameLabel;
        private System.Windows.Forms.Label acctNumberValue;
        private System.Windows.Forms.Label acctNameValue;
        private System.Windows.Forms.Label listCountValue;
        private System.Windows.Forms.Label acctAddressLabel;
        private System.Windows.Forms.Label acctAddressValue;
        private System.Windows.Forms.Label acctNRFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renewActiveBtn;
        private System.Windows.Forms.Button renewNRNPBtn;
        private System.Windows.Forms.Label outstandingBalanceValue;
        private System.Windows.Forms.Button loadAcctsBtn;
    }
}

