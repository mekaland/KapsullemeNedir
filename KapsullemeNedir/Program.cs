using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
          

            /* kapsülleme nedir?
             * içeride saklamış olduğumuz private fieldın önüne koymuş olduğumuz bir property sayesinde
             * get ve set bloklarını kullanarak değer atamasını da yapabiliriz ve değer çekebiliriz
             * Classın içerisinde bir alanın değer alma ve değer okuma kısımlarına müdehale ettiğimiz noktalara
             * kapsülleme diyoruz
             * field değer ataması yapılsın ama değer okunmasın
             * field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun
             * field değer ataması yapılmasın ama değer okunabilsin 
             * field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde
             * bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin 
             */

            // 1.field deger ataması yapılmasın ama okunabilsin 
            Console.WriteLine("Musteri Id Değeri = "+ M1.ID.ToString());
            M1.ID = 10;
            
            M1.TCkimliknumarasi = "12343121232";
            string TC = M1.TCkimliknumarasi;

            M1.isim = "kadir";
            M1.Soyisim = "Dagli";
            Console.WriteLine(M1.EmailAdres);
        }
    }
}
