namespace HTML_CREATOR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Linq;
    public partial class Form1 : Form
    {
        private BindingList<HtmlItems> _gekozenItems;
        BindingList<HtmlItems> _htmlItemsList;
        private StringBuilder sb;
        public Form1()
        {
            InitializeComponent();

            sb = new StringBuilder();

            _gekozenItems = new BindingList<HtmlItems>();
            _gekozenItems.ListChanged += _gekozenItems_ListChanged;
            listBox2.DataSource = _gekozenItems;
            listBox2.DisplayMember = "Label";            

            comboBox1.DataSource = HTML_CREATOR.Controls.ControlList;
            comboBox1.DisplayMember = "Name";

            _htmlItemsList = new BindingList<HtmlItems>(HtmlItems.HtmlItemsList);
            listBox1.DataSource = _htmlItemsList;
            listBox1.DisplayMember = "Label";


        }

        private void _gekozenItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (!_gekozenItems.Any()) buttonOpslaan.Enabled = false;
            else buttonOpslaan.Enabled = true;
            sb.Clear();

            sb.Append("<head>").Append(Environment.NewLine)
                .Append("<title>").Append(textBoxTitle.Text).Append("</title>").Append(Environment.NewLine)
                .Append("<style>").Append(Environment.NewLine)
                .Append("body { background-color: lightgray; }").Append(Environment.NewLine)
                .Append("label {display: inline-block; width: 140px; }​").Append(Environment.NewLine)
                .Append("</style>").Append(Environment.NewLine)
                .Append("</head>").Append(Environment.NewLine);  
                 
            foreach (var htmlitems in _gekozenItems)
            {
                sb.Append(htmlitems.Code).Append(Environment.NewLine);
            }
            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.OpenNew(false);
            webBrowser1.Document.Write(sb.ToString());
            webBrowser1.Refresh();

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
                BindingList<HtmlItems> combined = new BindingList<HtmlItems>();
                combined.AddRange(_gekozenItems);
                combined.AddRange(_htmlItemsList);

                var xEle = new XElement("HtmlItems",
                            from htmlItems in combined
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

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            if (((Controls)comboBox1.SelectedItem).Name == "Submit")
            {
                _htmlItemsList.Add(
                           new HtmlItems
                           {
                               Label = textBoxLabel.Text,
                               Code = "<div><" + ((Controls)comboBox1.SelectedItem).Code.ToString() + " value=\"" + textBoxLabel.Text + "\"></div>"
                           });
            }
            else{
                _htmlItemsList.Add(
                                new HtmlItems
                                {
                                    Label = textBoxLabel.Text,
                                    Code = "<div><label>" + textBoxLabel.Text + "</label><" + ((Controls)comboBox1.SelectedItem).Code.ToString() + "</div>"
                                });
            }

            textBoxLabel.Clear();
            
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

        private void Rechts_Click(object sender, EventArgs e)
        {
            foreach (HtmlItems h in _htmlItemsList)
            {
                _gekozenItems.Add(h);
            }

            foreach (HtmlItems h in _gekozenItems)
            {
                _htmlItemsList.Remove(h);
            }



        }

        private void Links_Click(object sender, EventArgs e)
        {
            foreach (HtmlItems h in _gekozenItems)
            {
                _htmlItemsList.Add(h);
            }

            foreach (HtmlItems h in _htmlItemsList)
            {
                _gekozenItems.Remove(h);
            }

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                _gekozenItems.Add((HtmlItems)listBox1.SelectedValue);
                _htmlItemsList.Remove((HtmlItems)listBox1.SelectedValue);
            }
            
        }

        private void Min_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                _htmlItemsList.Add((HtmlItems)listBox2.SelectedValue);
                _gekozenItems.Remove((HtmlItems)listBox2.SelectedValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Web Pagina | *.html";
            sfd.DefaultExt = "html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(@sfd.FileName, sb.ToString());
            }
        }
    }
}
