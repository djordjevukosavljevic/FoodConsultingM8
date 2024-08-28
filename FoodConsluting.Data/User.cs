using System.ComponentModel.DataAnnotations.Schema;

namespace FoodConsluting.Data{
    [Table("users")]
    public class User  : Base
    {
        public string Name { get; set;}
        public string Email { get; set;}
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set;}
        public enum USER_TYPE{
            ADMIN, PREMIUM_USER, USER
        }
        public USER_TYPE user;
    }
}