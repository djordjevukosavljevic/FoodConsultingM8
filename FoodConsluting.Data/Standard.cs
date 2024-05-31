namespace FoodConsluting.Data
{
    public class Standard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime ImplementTime{ get; set; }

        public string Description { get; set; }
    
        public List<Standard> Standards { get; set; }
    
    }
}
