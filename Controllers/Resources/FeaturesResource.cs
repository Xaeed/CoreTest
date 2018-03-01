using System.Collections.Generic;
using System.Collections.ObjectModel;
using testing.Models;

namespace testing.Controllers.Resources
{
    public class FeaturesResource
    {
      public int Id { get; set; }
       

         public string Name { get; set; }
          public bool PowerSteering { get; set; }

        public bool   Automatic { get; set; }
         public bool GPS { get; set; }
        
        // public Make Make { get; set; }
        // public int MakeId { get; set; }

        //   public ICollection<FeaturesResource> Features {get;set;}
        // public FeaturesResource()
        // {

        //  Features = new Collection<FeaturesResource>();
        // }
    }
}