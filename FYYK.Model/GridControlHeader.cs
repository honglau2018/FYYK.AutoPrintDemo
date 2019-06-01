using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYYK.Model
{
    public class GridControlHeader
    {
        public string Caption { get; set; }
        public string FieldName { get; set; }
        public string Visible { get; set; }
        public string CheckBox { get; set; }
        public string ReadOnly { get; set; }
        public int VisibleIndex { get; set; }
    }
}
