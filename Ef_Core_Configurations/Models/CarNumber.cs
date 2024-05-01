using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ef_Core_Configurations.Models
{
    public class CarNumber : BaseEntity
    {
        public string Number { get; set; }
    }
}
