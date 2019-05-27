using ANSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using Word = Microsoft.Office.Interop.Word;

namespace ANSystem.Helpers
{
    class Serialization
    {
        public static List<Sportsman> Download(List<Sportsman> list)
        {
            var xs = new XmlSerializer(list.GetType());
            var file = File.OpenRead("SportList");
            list = (List<Sportsman>)xs.Deserialize(file);
            file.Close();
            return list;
        }

        public static void Save(List<Sportsman> list)
        {
            var xs = new XmlSerializer(typeof(List<Sportsman>));
            var file = File.Create("SportList");
            xs.Serialize(file, list);
            file.Close();
        }

        public static string Encrypt(string input)
        {
            MD5 md5Hesher = MD5.Create();
            byte[] data = md5Hesher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i< data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString();
        }

        
    }
}
