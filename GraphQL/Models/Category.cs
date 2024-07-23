namespace GraphQL_Project.Models
{
    public record Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Menu> Menus { get; set; } = new List<Menu>();
    }
}
