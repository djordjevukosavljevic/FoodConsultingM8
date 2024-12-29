using System.ComponentModel.DataAnnotations.Schema;

namespace FoodConsluting.Data
{
    [Table("image")]
    public class Image : Base
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("path")]
        public string Path { get; set; }
        [Column("size")]
        public double Size { get; set; }
    }
}