namespace postit
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTrxType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTrxRef = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblBillingName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtLocationId = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtBillingName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCashier = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.richResults = new System.Windows.Forms.RichTextBox();
            this.lblUniqueTransId = new System.Windows.Forms.Label();
            this.richGetResults = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richPostresults = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 49);
            this.button1.TabIndex = 27;
            this.button1.Text = "POST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "GET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLocationId
            // 
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Location = new System.Drawing.Point(12, 17);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(60, 13);
            this.lblLocationId.TabIndex = 3;
            this.lblLocationId.Text = "Location Id";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(191, 17);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(72, 13);
            this.lblDevice.TabIndex = 4;
            this.lblDevice.Text = "Device Name";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 70);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblTrxType
            // 
            this.lblTrxType.AutoSize = true;
            this.lblTrxType.Location = new System.Drawing.Point(12, 94);
            this.lblTrxType.Name = "lblTrxType";
            this.lblTrxType.Size = new System.Drawing.Size(90, 13);
            this.lblTrxType.TabIndex = 6;
            this.lblTrxType.Text = "Transaction Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(191, 94);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // lblTrxRef
            // 
            this.lblTrxRef.AutoSize = true;
            this.lblTrxRef.Location = new System.Drawing.Point(191, 143);
            this.lblTrxRef.Name = "lblTrxRef";
            this.lblTrxRef.Size = new System.Drawing.Size(83, 13);
            this.lblTrxRef.TabIndex = 8;
            this.lblTrxRef.Text = "Transaction Ref";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Location = new System.Drawing.Point(192, 253);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(42, 13);
            this.lblCashier.TabIndex = 9;
            this.lblCashier.Text = "Cashier";
            // 
            // lblBillingName
            // 
            this.lblBillingName.AutoSize = true;
            this.lblBillingName.Location = new System.Drawing.Point(12, 201);
            this.lblBillingName.Name = "lblBillingName";
            this.lblBillingName.Size = new System.Drawing.Size(65, 13);
            this.lblBillingName.TabIndex = 10;
            this.lblBillingName.Text = "Billing Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(191, 201);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Street";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(13, 253);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "Zip";
            // 
            // txtLocationId
            // 
            this.txtLocationId.Location = new System.Drawing.Point(15, 34);
            this.txtLocationId.Name = "txtLocationId";
            this.txtLocationId.Size = new System.Drawing.Size(153, 20);
            this.txtLocationId.TabIndex = 3;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(194, 34);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(153, 20);
            this.txtDeviceName.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "CreditSale",
            "CreditReturn",
            "Void"});
            this.listBox1.Location = new System.Drawing.Point(15, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 69);
            this.listBox1.TabIndex = 15;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(194, 110);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(153, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(194, 159);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(153, 20);
            this.txtRef.TabIndex = 11;
            // 
            // txtBillingName
            // 
            this.txtBillingName.Location = new System.Drawing.Point(15, 217);
            this.txtBillingName.Name = "txtBillingName";
            this.txtBillingName.Size = new System.Drawing.Size(153, 20);
            this.txtBillingName.TabIndex = 13;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(194, 217);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(153, 20);
            this.txtStreet.TabIndex = 15;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(16, 269);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(153, 20);
            this.txtZip.TabIndex = 21;
            // 
            // txtCashier
            // 
            this.txtCashier.Location = new System.Drawing.Point(195, 269);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.Size = new System.Drawing.Size(153, 20);
            this.txtCashier.TabIndex = 23;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 305);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 22;
            this.lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(15, 321);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(332, 20);
            this.txtUrl.TabIndex = 25;
            this.txtUrl.Text = "https://cloud.chargeitpro.com/transaction.json";
            // 
            // richResults
            // 
            this.richResults.Location = new System.Drawing.Point(15, 348);
            this.richResults.Name = "richResults";
            this.richResults.Size = new System.Drawing.Size(278, 49);
            this.richResults.TabIndex = 29;
            this.richResults.Text = "";
            // 
            // lblUniqueTransId
            // 
            this.lblUniqueTransId.AutoSize = true;
            this.lblUniqueTransId.Location = new System.Drawing.Point(378, 17);
            this.lblUniqueTransId.Name = "lblUniqueTransId";
            this.lblUniqueTransId.Size = new System.Drawing.Size(83, 13);
            this.lblUniqueTransId.TabIndex = 25;
            this.lblUniqueTransId.Text = "Unique Trans Id";
            // 
            // richGetResults
            // 
            this.richGetResults.Location = new System.Drawing.Point(381, 113);
            this.richGetResults.Name = "richGetResults";
            this.richGetResults.Size = new System.Drawing.Size(240, 338);
            this.richGetResults.TabIndex = 37;
            this.richGetResults.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 49);
            this.button3.TabIndex = 38;
            this.button3.Text = "Generate JSON Object";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richPostresults
            // 
            this.richPostresults.Location = new System.Drawing.Point(16, 411);
            this.richPostresults.Name = "richPostresults";
            this.richPostresults.Size = new System.Drawing.Size(277, 49);
            this.richPostresults.TabIndex = 39;
            this.richPostresults.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(523, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 31);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(381, 470);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 31);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 479);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(58, 13);
            this.lblMsg.TabIndex = 42;
            this.lblMsg.Text = "Messages:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 513);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.richPostresults);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richGetResults);
            this.Controls.Add(this.lblUniqueTransId);
            this.Controls.Add(this.richResults);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtCashier);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtBillingName);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.txtLocationId);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblBillingName);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.lblTrxRef);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTrxType);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblLocationId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charge It Pro!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTrxType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTrxRef;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label lblBillingName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtBillingName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCashier;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RichTextBox richResults;
        private System.Windows.Forms.Label lblUniqueTransId;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.RichTextBox richGetResults;
        private System.Windows.Forms.RichTextBox richPostresults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMsg;
    }
}

