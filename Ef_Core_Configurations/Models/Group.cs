namespace Ef_Core_Configurations.Models
{
    public class Group :BaseEntity
    {
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
