using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Colspan
{

    public class JsonEntity
    {
        public string name { get; set; }
        public List<Link> links { get; set; }
    }

    public class Link
    {
        public string name { get; set; }
        public List<Child> dataList { get; set; }
        public object data { get; set; }
    }


}
