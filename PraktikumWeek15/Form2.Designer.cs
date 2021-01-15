namespace PraktikumWeek15
{
    partial class Form2
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
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubtotalHarga = new System.Windows.Forms.Label();
            this.labelTaxHarga = new System.Windows.Forms.Label();
            this.labelDiscountHarga = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.paneldiskon = new System.Windows.Forms.Panel();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelpersen = new System.Windows.Forms.Label();
            this.labelhargasub = new System.Windows.Forms.Label();
            this.labelhargatax = new System.Windows.Forms.Label();
            this.labelhargadiskon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paneldiskon.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(34, 38);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDiscount.TabIndex = 0;
            this.checkBoxDiscount.Text = "DISCOUNT";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            this.checkBoxDiscount.CheckedChanged += new System.EventHandler(this.checkBoxDiscount_CheckedChanged);
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(34, 149);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(97, 23);
            this.buttonHitung.TabIndex = 1;
            this.buttonHitung.Text = "CALCULATE";
            this.buttonHitung.UseVisualStyleBackColor = true;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(250, 42);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelSubtotal.TabIndex = 2;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(250, 66);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(25, 13);
            this.labelTax.TabIndex = 3;
            this.labelTax.Text = "Tax";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(250, 91);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(49, 13);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.Text = "Discount";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(250, 115);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // labelSubtotalHarga
            // 
            this.labelSubtotalHarga.AutoSize = true;
            this.labelSubtotalHarga.Location = new System.Drawing.Point(354, 38);
            this.labelSubtotalHarga.Name = "labelSubtotalHarga";
            this.labelSubtotalHarga.Size = new System.Drawing.Size(0, 13);
            this.labelSubtotalHarga.TabIndex = 6;
            // 
            // labelTaxHarga
            // 
            this.labelTaxHarga.AutoSize = true;
            this.labelTaxHarga.Location = new System.Drawing.Point(354, 66);
            this.labelTaxHarga.Name = "labelTaxHarga";
            this.labelTaxHarga.Size = new System.Drawing.Size(0, 13);
            this.labelTaxHarga.TabIndex = 7;
            // 
            // labelDiscountHarga
            // 
            this.labelDiscountHarga.AutoSize = true;
            this.labelDiscountHarga.Location = new System.Drawing.Point(354, 91);
            this.labelDiscountHarga.Name = "labelDiscountHarga";
            this.labelDiscountHarga.Size = new System.Drawing.Size(0, 13);
            this.labelDiscountHarga.TabIndex = 8;
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Location = new System.Drawing.Point(354, 115);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(0, 13);
            this.labelTotalHarga.TabIndex = 9;
            // 
            // paneldiskon
            // 
            this.paneldiskon.Controls.Add(this.labelpersen);
            this.paneldiskon.Controls.Add(this.textBox1);
            this.paneldiskon.Controls.Add(this.labelInput);
            this.paneldiskon.Location = new System.Drawing.Point(35, 70);
            this.paneldiskon.Name = "paneldiskon";
            this.paneldiskon.Size = new System.Drawing.Size(182, 59);
            this.paneldiskon.TabIndex = 10;
            this.paneldiskon.Visible = false;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(14, 22);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelpersen
            // 
            this.labelpersen.AutoSize = true;
            this.labelpersen.Location = new System.Drawing.Point(158, 23);
            this.labelpersen.Name = "labelpersen";
            this.labelpersen.Size = new System.Drawing.Size(15, 13);
            this.labelpersen.TabIndex = 2;
            this.labelpersen.Text = "%";
            // 
            // labelhargasub
            // 
            this.labelhargasub.AutoSize = true;
            this.labelhargasub.Location = new System.Drawing.Point(314, 43);
            this.labelhargasub.Name = "labelhargasub";
            this.labelhargasub.Size = new System.Drawing.Size(13, 13);
            this.labelhargasub.TabIndex = 11;
            this.labelhargasub.Text = "0";
            // 
            // labelhargatax
            // 
            this.labelhargatax.AutoSize = true;
            this.labelhargatax.Location = new System.Drawing.Point(314, 66);
            this.labelhargatax.Name = "labelhargatax";
            this.labelhargatax.Size = new System.Drawing.Size(13, 13);
            this.labelhargatax.TabIndex = 12;
            this.labelhargatax.Text = "0";
            // 
            // labelhargadiskon
            // 
            this.labelhargadiskon.AutoSize = true;
            this.labelhargadiskon.Location = new System.Drawing.Point(314, 93);
            this.labelhargadiskon.Name = "labelhargadiskon";
            this.labelhargadiskon.Size = new System.Drawing.Size(13, 13);
            this.labelhargadiskon.TabIndex = 13;
            this.labelhargadiskon.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelhargadiskon);
            this.Controls.Add(this.labelhargatax);
            this.Controls.Add(this.labelhargasub);
            this.Controls.Add(this.paneldiskon);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelDiscountHarga);
            this.Controls.Add(this.labelTaxHarga);
            this.Controls.Add(this.labelSubtotalHarga);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.checkBoxDiscount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.paneldiskon.ResumeLayout(false);
            this.paneldiskon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubtotalHarga;
        private System.Windows.Forms.Label labelTaxHarga;
        private System.Windows.Forms.Label labelDiscountHarga;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Panel paneldiskon;
        private System.Windows.Forms.Label labelpersen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelhargasub;
        private System.Windows.Forms.Label labelhargatax;
        private System.Windows.Forms.Label labelhargadiskon;
        private System.Windows.Forms.Label label3;
    }
}