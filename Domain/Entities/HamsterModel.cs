using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    /// <summary>
    /// Our Hamster object, Hamstermodel from project description
    /// </summary>
    public class HamsterModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(1)]
        public string? Name { get; set; }
        [Required]
        [Range(0, 3)]
        public int Age { get; set; }
        [StringLength(20)]
        public string? FavFood { get; set; }
        [StringLength(20)]
        public string? Loves { get; set; }
        public string? ImgName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }

    }
}
