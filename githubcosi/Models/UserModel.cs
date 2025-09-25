using System.ComponentModel.DataAnnotations;

namespace githubcosi.Models
{
    public class UserModel
    {
        [Required]
        public string Meno { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Range(1, 120)]
        public int Vek { get; set; }

        public string Mesto { get; set; }
        public string Telefon { get; set; }

        public List<string> Choroby { get; set; } = new List<string>();
    }
}
