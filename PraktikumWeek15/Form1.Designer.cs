namespace PraktikumWeek15
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
            this.labelBuDewi = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.labelMenu = new System.Windows.Forms.Label();
            this.comboBoxDaftar = new System.Windows.Forms.ComboBox();
            this.labelTulisanHarga = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.panelHilang = new System.Windows.Forms.Panel();
            this.panelHilang.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuDewi
            // 
            this.labelBuDewi.AutoSize = true;
            this.labelBuDewi.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuDewi.Location = new System.Drawing.Point(366, 19);
            this.labelBuDewi.Name = "labelBuDewi";
            this.labelBuDewi.Size = new System.Drawing.Size(93, 26);
            this.labelBuDewi.TabIndex = 0;
            this.labelBuDewi.Text = "Bu Dewi";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(198, 58);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(40, 13);
            this.labelItem.TabIndex = 1;
            this.labelItem.Text = "ITEMS";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(41, 85);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(197, 290);
            this.listBoxMenu.TabIndex = 2;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.Location = new System.Drawing.Point(244, 85);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(120, 290);
            this.listBoxHarga.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(201, 390);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(430, 96);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakanan.TabIndex = 5;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(538, 96);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 6;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(427, 135);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(34, 13);
            this.labelMenu.TabIndex = 7;
            this.labelMenu.Text = "Menu";
            // 
            // comboBoxDaftar
            // 
            this.comboBoxDaftar.FormattingEnabled = true;
            this.comboBoxDaftar.Location = new System.Drawing.Point(486, 135);
            this.comboBoxDaftar.Name = "comboBoxDaftar";
            this.comboBoxDaftar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDaftar.TabIndex = 8;
            this.comboBoxDaftar.SelectedIndexChanged += new System.EventHandler(this.comboBoxDaftar_SelectedIndexChanged);
            // 
            // labelTulisanHarga
            // 
            this.labelTulisanHarga.AutoSize = true;
            this.labelTulisanHarga.Location = new System.Drawing.Point(621, 138);
            this.labelTulisanHarga.Name = "labelTulisanHarga";
            this.labelTulisanHarga.Size = new System.Drawing.Size(45, 13);
            this.labelTulisanHarga.TabIndex = 9;
            this.labelTulisanHarga.Text = "Harga : ";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(684, 138);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(0, 13);
            this.labelHarga.TabIndex = 10;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(431, 177);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "Size ";
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(13, 18);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNormal.TabIndex = 12;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(95, 17);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonJumbo.TabIndex = 13;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(486, 282);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(115, 50);
            this.buttonBuy.TabIndex = 14;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(649, 361);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(117, 52);
            this.buttonCheckout.TabIndex = 15;
            this.buttonCheckout.Text = "Check Out";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // panelHilang
            // 
            this.panelHilang.Controls.Add(this.radioButtonNormal);
            this.panelHilang.Controls.Add(this.radioButtonJumbo);
            this.panelHilang.Location = new System.Drawing.Point(433, 204);
            this.panelHilang.Name = "panelHilang";
            this.panelHilang.Size = new System.Drawing.Size(183, 50);
            this.panelHilang.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHilang);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelTulisanHarga);
            this.Controls.Add(this.comboBoxDaftar);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.radioButtonMinuman);
            this.Controls.Add(this.radioButtonMakanan);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelBuDewi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelHilang.ResumeLayout(false);
            this.panelHilang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuDewi;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxDaftar;
        private System.Windows.Forms.Label labelTulisanHarga;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Panel panelHilang;
    }
}

