using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
