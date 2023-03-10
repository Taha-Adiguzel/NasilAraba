using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NasilAraba.Models
{
    public class Brand
    {
        [Required]
        [Key]
        [Display(Name = "Brand ID")]
        public int BrandID { get; set; }

        [Required]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
