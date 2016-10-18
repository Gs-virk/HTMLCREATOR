using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            
         //   listBox1.DataSource = Enum.GetValues(typeof(HtmlLijst));
            _gekozenItems = new BindingList<HtmlItems>();
            listBox2.DataSource = _gekozenItems;
            listBox2.DisplayMember = "Label";

            comboBox1.DataSource = HTML_CREATOR.Controls.ControlList;
            comboBox1.DisplayMember = "Name";

            _htmlItemsList = new BindingList<HtmlItems>();
            listBox1.DataSource = _htmlItemsList;
            listBox1.DisplayMember = "Label";                     
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var xEle = new XElement("HtmlItems",
                            from htmlItems in _htmlItemsList
                            select new XElement("Item",
                                           new XElement("Label", htmlItems.Label),
                                           new XElement("Code", htmlItems.Code)
                                       ));

                xEle.Save("htmlitems.xml");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
