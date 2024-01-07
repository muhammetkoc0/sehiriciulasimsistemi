using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
     public interface Interface1
    {
        int id { get; set; }
        string isim {  get; set; }     
        bool Sigorta { get; set; }
       

        int yeniKayit(int id, int yas, string isim, string soyisim, DateTime tarih, bool Sigorta );
        int kayitDuzenle(int id, int yas, string isim, string soyisim, DateTime tarih, bool Sigorta);
        int kayitSil(int id);
    }
}
