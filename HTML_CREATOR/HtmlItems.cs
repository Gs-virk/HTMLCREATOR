using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HTML_CREATOR
{
    class HtmlItems : Controls
    {
        private string _label;

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public static List<HtmlItems> HtmlItemsList
        {
            get
            {

                return (
                from e in XDocument.Load(@"htmlitems.xml").Root.Elements("Item")
                select new HtmlItems
                {
                    Label = (string)e.Element("Label"),
                    Code = (string)e.Element("Code")
                }).ToList();
            }
        }

        public static void Save(IEnumerable<HtmlItems> list)
        {
            try
            {
                var xEle = new XElement("HtmlItems",
                            from htmlItems in list
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
