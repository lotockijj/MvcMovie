using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class User
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string name { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password), Required]
        public string password { get; set; }
        
    }
}
