
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodConsluting.Data
{

    [Table("review")]
    public class Review
    {
        [Column("review_id")]
        public int Id { get; set; }
        [Column("company_name")]
        public string CompanyName { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("text")]
        public string Text { get; set; }
        public DateTime createdAt { get; set; }

    }
}