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
        private BindingList<HtmlItems> _gekozenItems;
        BindingList<HtmlItems> _htmlItemsList;
        public Form1()
        {
            InitializeComponent();
            _gekozenItems = new BindingList<HtmlItems>();
         //   listBox1.DataSource = Enum.GetValues(typeof(HtmlLijst));
            listBox2.DataSource = _gekozenItems;
            listBox2.DisplayMember = "Label";
            comboBox1.DataSource = HTML_CREATOR.Controls.ControlList;
            comboBox1.DisplayMember = "Name";
            _htmlItemsList = new BindingList<HtmlItems>();
            listBox1.DataSource = _htmlItemsList;
            listBox1.DisplayMember = "Label";          
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
            if (!string.IsNullOrWhiteSpace(textBoxLabel.Text))
            {
                comboBox1.Enabled = true;
                buttonNew.Enabled = true;

            }
            else
            {
                comboBox1.Enabled = false;
                buttonNew.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _gekozenItems.Add((HtmlItems)listBox1.SelectedValue);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            _htmlItemsList.Add(
                new HtmlItems
                {
                    Label = textBoxLabel.Text,
                    Code = ((Controls)comboBox1.SelectedValue).ToString()
                });
        }
    }
}
