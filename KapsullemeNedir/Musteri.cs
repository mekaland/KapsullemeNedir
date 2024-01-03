using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeNedir
{
    internal class Musteri
    {
        public Musteri() { 
            // bellekte nesne örneklenirken default olarak çalışıyodu benim vermiş olduğum kurala göre gidicek 
            // bir yerden değer öğrenicek öğrenmiş olduğu değeri içerde private olarak saklamış olduğum
            // fieldın içerisine atıcak ana görevi bu
        }
        private int id;
        public int ID
        {
            get //get ile private id deki değeri alıyorum property yardımıyla onu çağıran koda gönderiyorum
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string isim;
        private string _soyisim;
        public string Soyisim
        {
            get { return this._soyisim; }
            set
            {
                this.Soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@hotmail.com", isim, _soyisim);
            }
        }
       
        public string _tckimliknumarasi;
        public string TCkimliknumarasi
        {
            get
            {
                return _tckimliknumarasi.Substring(0,3);
            }
            set
            {
                if(value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0;i< value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if(karakterKontrol)
                        {
                            //sayısal degerdir 
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("TCkimlik içerisindeki değerler sayısal olmalıdır");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }

                else
                {
                    Console.WriteLine("Hatalı!");
                }
            }
        }

        private string emailAdres;
        public string EmailAdres
        {
           // get; database veya farklı veri kaynagı.. class cagıran programcıya detay gosterdiğimiz kısım...
          //  set; dış dünyadan alınan datanın içerde private olarak saklanan field içerisinde değer atandığı kısım

            private set
            {
                this.emailAdres = value;
            }
            get
            {
                return this.emailAdres;
            }
        }
        private int IDuret()
        {
            Random rnd = new Random();
            return rnd.Next(10000,90000);
        }
    }

}
