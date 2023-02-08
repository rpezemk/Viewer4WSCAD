using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Viewer4WSCAD.Types.Geometry;


namespace Viewer4WSCAD.BusinessLogic
{
    internal class JsonDeserializer : IDeserializer
    {
        public List<Root> GetFigures(string json)
        {
            List<Root> figures = new List<Root>();
            figures = JsonConvert.DeserializeObject<List<Root>>(json);
            return figures;
        }
    }

    internal class XmlDeserializer : IDeserializer
    {
        public List<Root> GetFigures(string json)
        {
            List<Root> figures = new List<Root>();


            return figures;
        }
    }
}
