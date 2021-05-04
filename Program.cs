using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcıdan_değer_alma__input_
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------Kullanıcıdan değer almak (input)-----------------------------------------------------------------------------



            // kullanıcıdan değerl almak için yazıyı ekranda  tutmak için kullandığımız Console.Readline(); komutunu kullanıyoruz peki nasıl?

            Console.WriteLine("Adınızı girin :");    // önce burda bir yazı yazdık kullanıcının değer yazmasını söylemek için 
            string Name = Console.ReadLine();       // işte input aldığımız yer burası Readline komutunu sadece string almak için kullanırız  aldığımız sonucuda Name'in içine kaydettik.

            Console.WriteLine("soy adınızı girin :"); // burda gine kullanıcıya sormak istediğimiz şeyi yazdık.
            string Surname = Console.ReadLine();     // burda input verdik kullanıcı değer girebilmesi için kullanıcının yazdığı değeride Surname in içine kaydettik.


            Console.WriteLine("Kullanıcı adını: " +  Name + " " + " Soyadı: "  + Surname );  // burda aldığımız sonuçları yazdırdık ben başına tırnak içinde bir kaç yazı ekledim eklediğim 
                                                                                            // yazıları birleştirmek için "+" kullandım.
            

            Console.WriteLine("kaç yılında doğdunuz;");  //burda gine kullanıcıya sormak isteğimiz soruyu sorduk.
            string yıl = Console.ReadLine();            //burda input verdik kullanıcıdan değer alıp "yıl" 'ın içine kaydettik.
                                                       //yukarda da dediğim gibi ReadLine(); komutunun içine int ekleyemeyiz bunun için veri dönüşümü yapcağız.
            int yıl1 = Convert.ToInt32(yıl);          //burda elimizdeki string olan "yıl" ı int e çevirdik bunuda Convert.ToInt32 komutuyla yaptık ve çevirdiğimiz 
                                                     //stringi int olarak "yıl1" değişkeninin içine attık.  
            int yas = (2021 - yıl1);                //burda artık int olan değişkenimizle matematiksel işlem yapabiliriz toplama,çıkarma,çarpme vs. eğer değiştirmeseydik     
                                                   //matematiksel işlem değil string birleştirme vs. işlemleri yapabilirdik sadece.
            Console.WriteLine("yaşınız: " + yas); //burda da artık ekrana yazdırdık tüm işlemler teker teker yapıldı şu ana kadar şimdi ekrana yazdırdık ben güzel durması amacıyla başına bir şeyler ekledim. 
            Console.ReadLine();                  //bu kodu da şimdiye kadar yaptığımız gibi konsolun açık kalması için kullandık.



            // ----------------------------------------------------------Kullanıcıdan değer alma (input) bitti-----------------------------------------------------------------------------
        }
    }
}
