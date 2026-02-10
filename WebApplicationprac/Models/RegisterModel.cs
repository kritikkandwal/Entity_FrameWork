using System.ComponentModel.DataAnnotations;

namespace WebApplicationprac.Models
{
    public class RegisterModel
    {
        [Key] //pk auto
        public int ID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool Status { get; set; }
    }
}
