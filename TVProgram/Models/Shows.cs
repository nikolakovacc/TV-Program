using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProgram.Models
{
 
    public class Shows
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public string Time { get; set; }
        public string Authors { get; set; }
        public string Day { get; set; }
        public string Channel { get; set; }
        public bool IsFavorite { get; set; }
        public string Name { get; set; }
        
    }

}
