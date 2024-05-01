namespace Ef_Core_Configurations.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
