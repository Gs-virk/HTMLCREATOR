namespace HTML_CREATOR
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    class Controls
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public static List<Controls> ControlList
        {
            get
            {
                return (
                    from e in XDocument.Load(@"controls.xml").Root.Elements("control")
                    select new Controls
                    {
                        Name = (string)e.Element("name"),
                        Code = (string)e.Element("code")
                    }).ToList();
            }
        }
    }
}
