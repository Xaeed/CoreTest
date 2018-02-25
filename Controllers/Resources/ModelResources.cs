using System.Collections.Generic;
using System.Collections.ObjectModel;
using testing.Models;

namespace testing.Controllers.Resources
{
    public class ModelResources
    {
        
         public int Id { get; set; }
    
         public string Name { get; set; }
        
       public ICollection<FeaturesResource> Features {get;set;}
        public ModelResources()
        {

            Features = new Collection<FeaturesResource>();
        }
    }
}