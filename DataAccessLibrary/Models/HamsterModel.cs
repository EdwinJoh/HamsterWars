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
        
        public string? Name { get; set; }
        public int Age { get; set; } 
        public string? FavFood { get; set; }
        public string? Loves { get; set; }
        public string? ImgName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }
       
    }
}
