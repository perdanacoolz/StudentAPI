using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class User
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // [Column(TypeName = "nvarchar(36)")]

        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Email { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string PasswordHash { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; } = "";
        
        public DateTime CreatedAt { get; set; } 
        
        public DateTime UpdatedAt { get; set; }  

    }
}
