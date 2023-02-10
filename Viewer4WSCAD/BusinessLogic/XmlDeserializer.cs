using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Viewer4WSCAD.Helpers;
using Viewer4WSCAD.Types;

namespace Viewer4WSCAD.Deserializers
{
    internal class XmlDeserializer : IDeserializer
    {
        public List<Root> GetGenericFigures(string xml) => SerializationHelpers.XmlDeserializeObject<List<Root>>(xml);
    }
}
