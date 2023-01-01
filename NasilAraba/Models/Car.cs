using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NasilAraba.Models
{
    public class Car
    {

        [Required]
        [Key]
        [Display(Name = "ID")]
        public int CarId { get; set; }

        public string CarPhoto { get; set; }

        [Required]
        [Display(Name = "Car Name")]
        public string CarName { get; set; }

        [Required]
        [Display(Name = "Brand ID")]
        public int BrandId { get; set; }

        [Display(Name = "Production Year")]
        public string ProductionYear { get; set; }

        [Display(Name = "Horse Power")]
        public int HorsePower { get; set; }

        [Display(Name = "Engine Size")]
        public int EngineSize { get; set; }

        [Display(Name = "Weight")]
        public int Weight { get; set; }

        [Display(Name = "Fuel Consumption")]
        public float FuelConsumption { get; set; }

        public Brand Brand { get; set; }
    }
}
