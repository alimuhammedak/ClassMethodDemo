using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMethodDemo.Entity;

namespace ClassMethodDemo.Concrete
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.MusteriNo);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.MusteriNo);
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi: " + musteri.MusteriNo);
        }

        public void AddRange(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri eklendi: " + musteri.MusteriNo);
            }
        }
    }
}
