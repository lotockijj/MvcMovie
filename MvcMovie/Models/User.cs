using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class User
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string name { get; set; }

        [StringLength(60, MinimumLength = 8)]
        public string password { get; set; }
        
    }
}
