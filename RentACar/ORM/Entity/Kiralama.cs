using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public class Kiralama : BaseEntity
    {
        public int ArabalarID { get; set; }
        public int YoneticilerID { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public DateTime? KiralamaSuresi { get; set; }
        public double FaturaTutari { get; set; }
    }
}
