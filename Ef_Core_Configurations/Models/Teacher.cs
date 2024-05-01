namespace Ef_Core_Configurations.Models
{
    public class Teacher :BaseEntity
    {
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
