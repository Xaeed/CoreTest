using System.Collections.Generic;
using System.Collections.ObjectModel;
using testing.Models;

namespace testing.Controllers.Resources
{
    public class MakeResources
    {
        
        public int Id { get; set; }
        
        public string  Name { get; set; }

        public ICollection<ModelResources> Model{get;set;}

       public MakeResources()
       {

           Model =new Collection<ModelResources>();
       }
    }
}