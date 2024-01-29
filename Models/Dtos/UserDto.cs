using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace csharp_crud_api.Models.Dtos
{
    public class UserDto
    {
        [Required]
        [MaxLength(25) , MinLength(3)]
        public string? Name { get; set; }
        [Required, EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime? CreatedAt { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime? UpdatedAt { get; set; }

        public void HashPassword(){
            using(var deriveBytes = new Rfc2898DeriveBytes(Password, 32, 10000))
            {
                byte[] salt = deriveBytes.Salt;
                byte[] key = deriveBytes.GetBytes(32);

                PasswordSalt = Convert.ToBase64String(salt);
                PasswordHash = Convert.ToBase64String(key);
            }
        }
        public string? PasswordSalt { get; set; }
        public string? PasswordHash { get; set; }
    }
}