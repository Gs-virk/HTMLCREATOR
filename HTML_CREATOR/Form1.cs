using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_CREATOR
{
    public enum HtmlLijst
    {
        Voornaam, Naam, Geslacht, Gehuwd, Geboortedatum,
        Studie, Email, Straat, Huisnummer, Postcode,
        Gemeente, Land, Telefoon
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(typeof(HtmlLijst).GetEnumNames());
            comboBox1.Items.AddRange(HTML_CREATOR.Controls.ControlList.ToArray());
            comboBox1.DisplayMember = "Name";
            MessageBox.Show("Test");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void FotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Title = "Open Image";
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" + "|All files (*.*)|*.*";

            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)) comboBox1.Enabled = true;
            else comboBox1.Enabled = false;
        }
    }
}
