using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise05
{
    class Program
    {
        private static object obj;

        static void Main(string[] args)
        {
            //UnicodeEncoding aUE = new UnicodeEncoding();
            //byte[] key = aUE.GetBytes("password");
            //RijndaelManaged RMCrypto = new RijndaelManaged();
            //using (FileStream fs = File.Open(@"C:\Users\default.LAPTOP-JH4HG8JO\Desktop\pots\Sample.xml", FileMode.Create))
            //{
            //    using (CryptoStream cs = new CryptoStream(fs, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write))
            //    {
            //        XmlSerializer xmlser = new XmlSerializer(obj.GetType());
            //        xmlser.Serialize(cs, obj);
            //    }
            //    fs.Close();

            Aes key = null;

            try
            {
                // Create a new AES key.
                key = Aes.Create();
                // Load an XML document.
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.Load("customer.xml");
                // Encrypt the "creditcard" element.
                Encrypt(xmlDoc, "creditcard", key);

                Console.WriteLine("The element was encrypted");

                Console.WriteLine(xmlDoc.InnerXml);

                Decrypt(xmlDoc, key);

                Console.WriteLine("The element was decrypted");
                Console.Read();

                Console.WriteLine(xmlDoc.InnerXml);
              //  XmlElement elementToEncrypt = xmlDoc.GetElementsByTagName(creditcard)[0] as XmlElement;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Clear the key.
                if (key != null)
                {
                    key.Clear();
                }
            }
        }

        private static void Decrypt(XmlDocument xmlDoc, Aes key)
        {
            throw new NotImplementedException();
        }

        private static void Encrypt(XmlDocument xmlDoc, string v, Aes key)
        {
            throw new NotImplementedException();
        }

    }
}
