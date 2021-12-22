using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MCD_SystemXmlKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Xml oluşturma
            //XmlTextWriter xmlText = new XmlTextWriter(@"e:\xml\personellerim.xml",System.Text.UTF8Encoding.UTF8);
            ////Yorum yapma
            //xmlText.WriteComment("Buraya yorum yazabiliriz.");
            ////Root oluşturma
            //xmlText.WriteStartElement("Personellerim");
            ////1.Personel için;
            ////Child oluşturma
            //xmlText.WriteStartElement("Personel");
            //xmlText.WriteAttributeString("ID", "1");//Sıfat belirtir
            ////Subchild oluşturma
            //xmlText.WriteElementString("İsim", "Hakan");
            //xmlText.WriteElementString("Soyisim", "Darak");
            //xmlText.WriteElementString("Email", "hakandarak1@gmail.com");
            ////Child element kapatma
            //xmlText.WriteEndElement();

            ////2.Personel için
            ////Child oluşturma
            //xmlText.WriteStartElement("Personel");
            //xmlText.WriteAttributeString("ID", "2");
            ////Subchild oluşturma
            //xmlText.WriteElementString("İsim", "Mehmet");
            //xmlText.WriteElementString("Soyisim", "Darak");
            //xmlText.WriteElementString("Email", "mehmetdarak@gmail.com");
            ////Child element kapatma
            //xmlText.WriteEndElement();
            ////RootKapatma
            //xmlText.WriteEndElement();
            //xmlText.Close();
            #endregion

            #region Xml Okuma

            XmlReader reader = XmlReader.Create(@"e:\xml\personellerim.xml");

            while (reader.Read())//xml deyimlerini içerip içermedigine göre bool deger döndürür.
            {
                if (reader.IsStartElement())//başlangıc elementi olup olmadıgını kontrol eder.
                {
                    
                    if (reader.MoveToFirstAttribute())
                    {
                        Console.WriteLine("ID " + reader.Value.ToString());
                    }
                    switch (reader.Name.ToString())//dönen string degerleri okuyup swtich içerisine gireriz isim,soyisim ve email degerlerinden biri dönerse durumu saglayıp konsol ekranına basacak.
                    {
                        case "İsim":
                            Console.WriteLine("İsim " + reader.ReadString());
                            break;
                        case "Soyisim":
                            Console.WriteLine("Soyisim " + reader.ReadString());
                            break;
                        case "Email":
                            Console.WriteLine("Email " + reader.ReadString());
                            break;
                    }
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

            #endregion

        }
    }
}
