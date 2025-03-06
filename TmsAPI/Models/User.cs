using System.ComponentModel.DataAnnotations;

namespace TmsAPI.Models
{
    public class User
    {
        [Key]
        public Guid userGuid { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string userName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(300)]
        public string email { get; set; }
        [Required]
        [StringLength(20)]
        public string password { get; set; }
        [Required]
        public Boolean isActive { get; set; }
    }
}
