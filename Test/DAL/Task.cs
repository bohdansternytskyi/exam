using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.DAL
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }
        [MaxLength(256)]
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
