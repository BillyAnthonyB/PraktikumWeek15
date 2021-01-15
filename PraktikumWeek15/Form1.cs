using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
            panelHilang.Visible = false;
            labelSize.Visible = false;
            comboBoxDaftar.Items.Clear();
            comboBoxDaftar.Items.Add("Nasi Goreng");
            comboBoxDaftar.Items.Add("Nasi Goreng Special");
            comboBoxDaftar.Items.Add("Nasi Goreng Pete");
            comboBoxDaftar.Items.Add("Ayam Bakar");
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            panelHilang.Visible = true;
            labelSize.Visible = true;
            comboBoxDaftar.Items.Clear();
            comboBoxDaftar.Items.Add("Es Teh");
            comboBoxDaftar.Items.Add("Teh Hangat");
            comboBoxDaftar.Items.Add("Nutrisari");
            comboBoxDaftar.Items.Add("Aqua");
            labelHarga.Text = Convert.ToString(5000);
            labelHarga.Text = "7000";
            labelHarga.Text = "3000";
            labelHarga.Text = "5000";
            labelHarga.Text = "6000";
            labelHarga.Text = "10000";
            labelHarga.Text = "2000";
            labelHarga.Text = "5000";
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Add(comboBoxDaftar.SelectedItem);
            listBoxHarga.Items.Add(labelHarga.Text);
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.Items.Count == 0)
            {
                MessageBox.Show("GA ADA MENU BELIO SEK");
            }
            Form2 newform = new Form2();
            newform.Show();
        }

        private void comboBoxDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDaftar.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelHarga.Text = "10000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Nasi Goreng Special")
            {
                labelHarga.Text = "12000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                labelHarga.Text = "15000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Ayam Bakar")
            {
                labelHarga.Text = "15000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Es Teh" && radioButtonNormal.Checked)
            {
                labelHarga.Text = "5000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Es Teh" && radioButtonJumbo.Checked)
            {
                labelHarga.Text = "7000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Teh Hangat" && radioButtonNormal.Checked)
            {
                labelHarga.Text = "3000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Teh Hangat" && radioButtonJumbo.Checked)
            {
                labelHarga.Text = "5000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Nutrisari" && radioButtonNormal.Checked)
            {
                labelHarga.Text = "6000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Nutrisari" && radioButtonJumbo.Checked)
            {
                labelHarga.Text = "10000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Aqua" && radioButtonNormal.Checked)
            {
                labelHarga.Text = "2000";
            }
            else if (comboBoxDaftar.SelectedItem.ToString() == "Aqua" && radioButtonJumbo.Checked)
            {
                labelHarga.Text = "5000";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxHarga.Items.RemoveAt(listBoxMenu.SelectedIndex);
            listBoxMenu.Items.RemoveAt(listBoxMenu.SelectedIndex);
        }
    }
}
