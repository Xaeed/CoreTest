using System.ComponentModel.DataAnnotations.Schema;

namespace testing.Models
{
    [Table("Models")]
    public class Model
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public Make Make { get; set; }
         public int MakeId { get; set; }
    }
}