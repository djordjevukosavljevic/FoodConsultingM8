using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodConsluting.Data
{
    [Table("standards")]
    public class Standard : Base
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("Price")]
        public double Price { get; set; }
        [Column("implementTime")]
        public DateTime ImplementTime{ get; set; }
        [Column("description")]
        public string Description { get; set; }
    
        public List<Standard> Standards { get; set; }
    
    }
}
