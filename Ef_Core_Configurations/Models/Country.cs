namespace Ef_Core_Configurations.Models
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Cities = new List<City>();
        }

        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
