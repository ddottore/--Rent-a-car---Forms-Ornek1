namespace __Rent_a_car___Forms_Örnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxPriceList = new System.Windows.Forms.ListBox();
            this.lblPriceList = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbxCarCap = new System.Windows.Forms.ListBox();
            this.lblCarCap = new System.Windows.Forms.Label();
            this.lbxRent = new System.Windows.Forms.ListBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPriceList
            // 
            this.lbxPriceList.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxPriceList.FormattingEnabled = true;
            this.lbxPriceList.ItemHeight = 23;
            this.lbxPriceList.Location = new System.Drawing.Point(37, 73);
            this.lbxPriceList.Name = "lbxPriceList";
            this.lbxPriceList.Size = new System.Drawing.Size(134, 257);
            this.lbxPriceList.TabIndex = 0;
            this.lbxPriceList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPriceList
            // 
            this.lblPriceList.AutoSize = true;
            this.lblPriceList.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriceList.Location = new System.Drawing.Point(37, 35);
            this.lblPriceList.Name = "lblPriceList";
            this.lblPriceList.Size = new System.Drawing.Size(134, 20);
            this.lblPriceList.TabIndex = 1;
            this.lblPriceList.Text = "Fiyat Araligi\r\n";
            this.lblPriceList.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(91, 345);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(223, 67);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // lbxCarCap
            // 
            this.lbxCarCap.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCarCap.FormattingEnabled = true;
            this.lbxCarCap.ItemHeight = 23;
            this.lbxCarCap.Location = new System.Drawing.Point(248, 71);
            this.lbxCarCap.Name = "lbxCarCap";
            this.lbxCarCap.Size = new System.Drawing.Size(134, 257);
            this.lbxCarCap.TabIndex = 4;
            this.lbxCarCap.SelectedIndexChanged += new System.EventHandler(this.lbxCarCap_SelectedIndexChanged);
            // 
            // lblCarCap
            // 
            this.lblCarCap.AutoSize = true;
            this.lblCarCap.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarCap.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCarCap.Location = new System.Drawing.Point(244, 35);
            this.lblCarCap.Name = "lblCarCap";
            this.lblCarCap.Size = new System.Drawing.Size(114, 20);
            this.lblCarCap.TabIndex = 5;
            this.lblCarCap.Text = "Kac Kisilik";
            this.lblCarCap.Click += new System.EventHandler(this.lblCarModel_Click);
            // 
            // lbxRent
            // 
            this.lbxRent.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxRent.ForeColor = System.Drawing.Color.Blue;
            this.lbxRent.FormattingEnabled = true;
            this.lbxRent.ItemHeight = 23;
            this.lbxRent.Location = new System.Drawing.Point(454, 73);
            this.lbxRent.Name = "lbxRent";
            this.lbxRent.Size = new System.Drawing.Size(325, 211);
            this.lbxRent.TabIndex = 6;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRent.Location = new System.Drawing.Point(456, 35);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(247, 20);
            this.lblRent.TabIndex = 7;
            this.lblRent.Text = "Firmanin Onerdigi Araba\r\n";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(518, 330);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(185, 82);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lbxRent);
            this.Controls.Add(this.lblCarCap);
            this.Controls.Add(this.lbxCarCap);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblPriceList);
            this.Controls.Add(this.lbxPriceList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxPriceList;
        private Label lblPriceList;
        private Button btnSelect;
        private ListBox lbxCarCap;
        private Label lblCarCap;
        private ListBox lbxRent;
        private Label lblRent;
        private Button btnConfirm;
    }
}