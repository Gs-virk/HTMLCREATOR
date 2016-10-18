using System;
using System.Collections.Generic;
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
    }
}
