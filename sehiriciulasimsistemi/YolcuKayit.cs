using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class YolcuKayit
    {
        int id;
        string ad;
        string soyad;
        DateTime dogumTarihi;
        bool erkek;
        bool kadın;
        string kategori;

        public int Id { get { return id; } set { id =  value; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Soyad { get {  return soyad; } set {  soyad = value; } }
        public DateTime DogumTarihi { get {  return dogumTarihi; } set {  dogumTarihi = value; } }
        public bool Erkek { get { return erkek; } set { erkek = value; } }  
        public bool Kadın { get { return kadın; } set { kadın = value; } }
        public string Kategori { get;  set; }
    }
}
