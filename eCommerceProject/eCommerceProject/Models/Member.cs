using System.ComponentModel.DataAnnotations;

namespace eCommerceProject.Models
{
    public class Member
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Surname { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";   

    }
}
