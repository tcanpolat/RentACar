using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public abstract class BaseEntity
    {
       //Int nun-nullable bir değer olduğu için, required gereksiz gibi.
        public int ID { get; set; }

        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        //Boolean non-nullable bir değer olduğu için required gereksiz gibi, best practice olsun diye belki true belirlenebilir.
        public bool AktifMi { get; set; } = true;
    }
}
