using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public class Kiralama : BaseEntity
    {
        //Instance alınır alınmaz alış tarihini şimdi belirleyebilir.
        public Kiralama()
        {
            AlisTarihi = DateTime.Now;
        }
        public int ArabaID { get; set; }
        public int YoneticiID { get; set; }

        public virtual Araba Araba { get; set; }
        public virtual Yonetici Yonetici { get; set; }

        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        //TimeSpan özelliği ile süre hesaplanabilir
        public TimeSpan KiralamaSuresi { get; set; }
        public double FaturaTutari { get; set; }
    }
}
