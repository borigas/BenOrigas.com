using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace BenOrigas.com.Models
{
    public static class HelperMethods
    {
        public static string ToCssString(this string str)
        {
            return str.ToLower().Replace(' ', '-');
        }

        public static T Deserialize<T>(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlReader xmlReader = new XmlTextReader(fs);

            T result = (T)serializer.Deserialize(xmlReader);

            xmlReader.Close();
            fs.Close();

            return result;
        }
    }
}