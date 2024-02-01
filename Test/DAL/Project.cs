using System.ComponentModel.DataAnnotations;

namespace Test.DAL
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
