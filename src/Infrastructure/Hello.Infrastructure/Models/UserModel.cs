using System.ComponentModel.DataAnnotations.Schema;

namespace Hello.Infrastructure.Models
{
    [Table("Users")]
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}