using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    /// <summary>
    /// ResultModel from project description
    /// </summary>
    public class ResultModel
    {
        public int Id { get; set; }
        public int WinnerId { get; set; }
        public int LoserId { get; set; }

    }
}
