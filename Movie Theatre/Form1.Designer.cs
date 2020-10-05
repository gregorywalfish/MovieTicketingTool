namespace Movie_Theatre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberAdultsTxt = new System.Windows.Forms.TextBox();
            this.NumberKidsTxt = new System.Windows.Forms.TextBox();
            this.NumberSeniorsTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegularPriceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalPriceAfterDiscountLbl = new System.Windows.Forms.Label();
            this.GrandTotalPriceLbl = new System.Windows.Forms.Label();
            this.TaxesLbl = new System.Windows.Forms.Label();
            this.GroupDiscountLbl = new System.Windows.Forms.Label();
            this.AmountDueLbl = new System.Windows.Forms.Label();
            this.SeniorsPriceLbl = new System.Windows.Forms.Label();
            this.KidsPriceLbl = new System.Windows.Forms.Label();
            this.AdultsPriceLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Adults 14 or older";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# of Kids less than 14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "# of Seniors above 65";
            // 
            // NumberAdultsTxt
            // 
            this.NumberAdultsTxt.Location = new System.Drawing.Point(169, 53);
            this.NumberAdultsTxt.Name = "NumberAdultsTxt";
            this.NumberAdultsTxt.Size = new System.Drawing.Size(30, 20);
            this.NumberAdultsTxt.TabIndex = 3;
            // 
            // NumberKidsTxt
            // 
            this.NumberKidsTxt.Location = new System.Drawing.Point(169, 97);
            this.NumberKidsTxt.Name = "NumberKidsTxt";
            this.NumberKidsTxt.Size = new System.Drawing.Size(30, 20);
            this.NumberKidsTxt.TabIndex = 4;
            this.NumberKidsTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NumberSeniorsTxt
            // 
            this.NumberSeniorsTxt.Location = new System.Drawing.Point(169, 141);
            this.NumberSeniorsTxt.Name = "NumberSeniorsTxt";
            this.NumberSeniorsTxt.Size = new System.Drawing.Size(30, 20);
            this.NumberSeniorsTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Regular Price";
            // 
            // RegularPriceTxt
            // 
            this.RegularPriceTxt.Location = new System.Drawing.Point(143, 13);
            this.RegularPriceTxt.Name = "RegularPriceTxt";
            this.RegularPriceTxt.Size = new System.Drawing.Size(79, 20);
            this.RegularPriceTxt.TabIndex = 7;
            this.RegularPriceTxt.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "= $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "= $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "= $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Group Discount = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grand Total Price = $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Price After Discount = $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Taxes (15%) = $";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amount Due = $";
            // 
            // TotalPriceAfterDiscountLbl
            // 
            this.TotalPriceAfterDiscountLbl.AutoSize = true;
            this.TotalPriceAfterDiscountLbl.Location = new System.Drawing.Point(181, 261);
            this.TotalPriceAfterDiscountLbl.Name = "TotalPriceAfterDiscountLbl";
            this.TotalPriceAfterDiscountLbl.Size = new System.Drawing.Size(0, 13);
            this.TotalPriceAfterDiscountLbl.TabIndex = 20;
            // 
            // GrandTotalPriceLbl
            // 
            this.GrandTotalPriceLbl.AutoSize = true;
            this.GrandTotalPriceLbl.Location = new System.Drawing.Point(143, 192);
            this.GrandTotalPriceLbl.Name = "GrandTotalPriceLbl";
            this.GrandTotalPriceLbl.Size = new System.Drawing.Size(0, 13);
            this.GrandTotalPriceLbl.TabIndex = 21;
            // 
            // TaxesLbl
            // 
            this.TaxesLbl.AutoSize = true;
            this.TaxesLbl.Location = new System.Drawing.Point(120, 293);
            this.TaxesLbl.Name = "TaxesLbl";
            this.TaxesLbl.Size = new System.Drawing.Size(0, 13);
            this.TaxesLbl.TabIndex = 22;
            // 
            // GroupDiscountLbl
            // 
            this.GroupDiscountLbl.AutoSize = true;
            this.GroupDiscountLbl.Location = new System.Drawing.Point(134, 227);
            this.GroupDiscountLbl.Name = "GroupDiscountLbl";
            this.GroupDiscountLbl.Size = new System.Drawing.Size(0, 13);
            this.GroupDiscountLbl.TabIndex = 23;
            // 
            // AmountDueLbl
            // 
            this.AmountDueLbl.AutoSize = true;
            this.AmountDueLbl.Location = new System.Drawing.Point(119, 325);
            this.AmountDueLbl.Name = "AmountDueLbl";
            this.AmountDueLbl.Size = new System.Drawing.Size(0, 13);
            this.AmountDueLbl.TabIndex = 27;
            // 
            // SeniorsPriceLbl
            // 
            this.SeniorsPriceLbl.AutoSize = true;
            this.SeniorsPriceLbl.Location = new System.Drawing.Point(228, 141);
            this.SeniorsPriceLbl.Name = "SeniorsPriceLbl";
            this.SeniorsPriceLbl.Size = new System.Drawing.Size(0, 13);
            this.SeniorsPriceLbl.TabIndex = 28;
            // 
            // KidsPriceLbl
            // 
            this.KidsPriceLbl.AutoSize = true;
            this.KidsPriceLbl.Location = new System.Drawing.Point(228, 97);
            this.KidsPriceLbl.Name = "KidsPriceLbl";
            this.KidsPriceLbl.Size = new System.Drawing.Size(0, 13);
            this.KidsPriceLbl.TabIndex = 29;
            // 
            // AdultsPriceLbl
            // 
            this.AdultsPriceLbl.AutoSize = true;
            this.AdultsPriceLbl.Location = new System.Drawing.Point(228, 56);
            this.AdultsPriceLbl.Name = "AdultsPriceLbl";
            this.AdultsPriceLbl.Size = new System.Drawing.Size(0, 13);
            this.AdultsPriceLbl.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Bill Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdultsPriceLbl);
            this.Controls.Add(this.KidsPriceLbl);
            this.Controls.Add(this.SeniorsPriceLbl);
            this.Controls.Add(this.AmountDueLbl);
            this.Controls.Add(this.GroupDiscountLbl);
            this.Controls.Add(this.TaxesLbl);
            this.Controls.Add(this.GrandTotalPriceLbl);
            this.Controls.Add(this.TotalPriceAfterDiscountLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegularPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberSeniorsTxt);
            this.Controls.Add(this.NumberKidsTxt);
            this.Controls.Add(this.NumberAdultsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Movie Theatre Price Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberAdultsTxt;
        private System.Windows.Forms.TextBox NumberKidsTxt;
        private System.Windows.Forms.TextBox NumberSeniorsTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegularPriceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TotalPriceAfterDiscountLbl;
        private System.Windows.Forms.Label GrandTotalPriceLbl;
        private System.Windows.Forms.Label TaxesLbl;
        private System.Windows.Forms.Label GroupDiscountLbl;
        private System.Windows.Forms.Label AmountDueLbl;
        private System.Windows.Forms.Label SeniorsPriceLbl;
        private System.Windows.Forms.Label KidsPriceLbl;
        private System.Windows.Forms.Label AdultsPriceLbl;
        private System.Windows.Forms.Button button1;
    }
}

