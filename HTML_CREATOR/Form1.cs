namespace HTML_CREATOR
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;
    public partial class Form1 : Form
    {
        private BindingList<HtmlItems> _gekozenItems;
        BindingList<HtmlItems> _htmlItemsList;
        public Form1()
        {
            InitializeComponent();
            
            _gekozenItems = new BindingList<HtmlItems>();
            listBox2.DataSource = _gekozenItems;
            listBox2.DisplayMember = "Label";

            comboBox1.DataSource = HTML_CREATOR.Controls.ControlList;
            comboBox1.DisplayMember = "Name";

            _htmlItemsList = new BindingList<HtmlItems>(HtmlItems.HtmlItemsList);
            listBox1.DataSource = _htmlItemsList;
            listBox1.DisplayMember = "Label";
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLabel.Text))
            {
                comboBox1.Enabled = true;
                Toevoegen.Enabled = true;

            }
            else
            {
                comboBox1.Enabled = false;
                Toevoegen.Enabled = false;
            }
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

        private void Plus_Click(object sender, EventArgs e)
        {
            _gekozenItems.Add((HtmlItems)listBox1.SelectedValue);
        }

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            _htmlItemsList.Add(
                new HtmlItems
                {
                    Label = textBoxLabel.Text,
                    Code = ((Controls)comboBox1.SelectedItem).Code.ToString()
                });
        }

        private void UP_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newIndex = listBox2.SelectedIndex - 1;
                if (newIndex < 0)
                    return;
                object selecteditem = listBox2.SelectedItem;

                listBox2.Items.Remove(selecteditem);

                listBox2.Items.Insert(newIndex, selecteditem);

                listBox2.SetSelected(newIndex, true);
            }
        }
    }
}
