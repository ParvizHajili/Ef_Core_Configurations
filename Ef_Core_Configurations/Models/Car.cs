using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ef_Core_Configurations.Models
{
    public class Car : BaseEntity
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int CarNumberId { get; set; }
        public CarNumber CarNumber { get; set; }
    }
}
