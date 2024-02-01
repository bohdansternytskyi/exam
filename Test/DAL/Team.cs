using System.ComponentModel.DataAnnotations;

namespace Test.DAL
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
