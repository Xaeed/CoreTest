using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testing.Models
{
    [Table("Models")]
    public class Model
    {
         public int Id { get; set; }
        [Required]
         [StringLength(255)]
       

         public string Name { get; set; }
         public Make Make { get; set; }
         public int MakeId { get; set; }
          public ICollection<Features> Features {get;set;}
        public Model()
        {

            Features = new Collection<Features>();
        }
    }
}