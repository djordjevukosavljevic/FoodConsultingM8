using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Org.BouncyCastle.Asn1.Cms;

namespace FoodConsluting.Data
{
    [Table("standards")]
    public class Standard : Base
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("implementTime")]
        public Time ImplementTime{ get; set; }
        [Column("description")]
        public string Description { get; set; }
        public List<Standard> Standards { get; set; }
    
    }
}
