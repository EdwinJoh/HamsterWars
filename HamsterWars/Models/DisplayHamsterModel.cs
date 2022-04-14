using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars.Models
{
    public class DisplayHamsterModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name to long")]
        [MinLength(1, ErrorMessage = "Name to short")]
        public string? Name { get; set; }

        [Required]
        [Range(0, 3)]
        public int Age { get; set; }

        [StringLength(20, ErrorMessage = "Favourite food too long")]
        public string? FavFood { get; set; }
        [StringLength(20, ErrorMessage = "Favourite activity too long")]
        public string? Loves { get; set; }
        [Required]
        public string? ImgName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }
    }
}
