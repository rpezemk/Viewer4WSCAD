using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Viewer4WSCAD.Types.Geometry;

namespace Viewer4WSCAD.BusinessLogic
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Root
    {
        public string type { get; set; }
        public string a { get; set; }
        public string b { get; set; }
        public string color { get; set; }
        public string center { get; set; }
        public double? radius { get; set; }
        public bool? filled { get; set; }
        public string c { get; set; }
    }

}
