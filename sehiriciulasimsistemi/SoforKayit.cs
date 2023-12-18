using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class SoforKayit : Interface1
    {
        int _id;
        string _isim;
        string _soyisim;
        int _yas;
        DateTime _tarih;
        
        public int id { get { return _id; } set { _id = value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

       public DateTime tarih { get { return _tarih; } set { _tarih = value; } }

        public int yas { get { return _yas; } set { _yas = value; } }

        public int kayitDuzenle(int id, int yas, string isim, string soyisim, DateTime tarih)
        {
            Console.WriteLine("Kayıt Düzenlendi");
            return 1;

        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Kayıt Silindi");
            return 1;
        }

        public int yeniKayit(int id, int yas, string isim, string soyisim, DateTime tarih)
        {


            Console.WriteLine("Kayıt Eklendi");
            return 1;
        }
    
    }
}
