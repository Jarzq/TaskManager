using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        
        [Required(ErrorMessage = "Required Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
