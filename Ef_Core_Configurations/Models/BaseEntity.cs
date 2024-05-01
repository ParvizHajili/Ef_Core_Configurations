namespace Ef_Core_Configurations.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
    }
}
