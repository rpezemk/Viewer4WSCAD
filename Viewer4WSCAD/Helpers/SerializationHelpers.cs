using System.IO;
using System.Xml.Serialization;

namespace Viewer4WSCAD.Helpers
{
    /// <summary>
    /// Serialization helpers
    /// </summary>
    internal static class SerializationHelpers
    {
        public static string XmlSerializeObject<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static T XmlDeserializeObject<T>(string text)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (StringReader textWriter = new StringReader(text))
            {
                return (T) xmlSerializer.Deserialize(textWriter);
            }
        }
    }
}
