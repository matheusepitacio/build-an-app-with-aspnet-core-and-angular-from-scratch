using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DT0s{
    
    public class RegisterDto{
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}