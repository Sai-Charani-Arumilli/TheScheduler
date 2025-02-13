using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerApp.Models
{
    [Table("dbo.users")]
    public class User
    {
        [Key]
        public int id { get; set; }

        
        public string? First_Name { get; set; }

        
        public string? Last_Name { get; set; }
    }
}
