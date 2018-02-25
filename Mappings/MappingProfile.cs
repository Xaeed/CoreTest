using AutoMapper;
using testing.Models;
using testing.Controllers.Resources;

namespace testing.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
               CreateMap<Make,MakeResources>();
               CreateMap<Model,ModelResources>();
               CreateMap<Features,FeaturesResource>();

        }
    }
}