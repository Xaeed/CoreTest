using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace testing.Models
{
    public class Make
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string  Name { get; set; }

        public ICollection<Model> Model{get;set;}

       public Make()
       {

           Model =new Collection<Model>();
       }
    }
}