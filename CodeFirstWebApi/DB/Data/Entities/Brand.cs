using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Data.Entities
{
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }

        //Colección de cervezas que pertenecen a la marca
        public virtual ICollection<Beer> Beers { get; set; }
    }
}
