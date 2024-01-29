using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_crud_api.Models
{
		[Table("Users")]
		public class User
		{
			[Column("id")]
			public Guid Id { get; set; }
			[Column("name")]
			public string? Name { get; set; }
			[Column("email")]
			public string? Email { get; set; }
			[Column("password")]
			public string? Password { get; set; }
			[Column("created_at")]
			public DateTime? CreatedAt { get; set; }
			[Column("updated_at")]
			public DateTime? UpdatedAt { get; set; }
			[Column("password_salt")]
			public string? PasswordSalt { get; set; }
			[Column("password_hash")]
			public string? PasswordHash { get; set; }
		}

}
