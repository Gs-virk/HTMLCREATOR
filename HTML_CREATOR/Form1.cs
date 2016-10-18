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
        private BindingList<HtmlLijst> _gekozenItems;
        public Form1()
        {
            InitializeComponent();
            _gekozenItems = new BindingList<HtmlLijst>();
            listBox1.DataSource = Enum.GetValues(typeof(HtmlLijst));
            listBox2.DataSource = _gekozenItems;
            comboBox1.Items.AddRange(HTML_CREATOR.Controls.ControlList.ToArray());
            comboBox1.DisplayMember = "Name";
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

        private void button2_Click(object sender, EventArgs e)
        {
            _gekozenItems.Add((HtmlLijst)listBox1.SelectedValue);
        }
    }
}
