namespace testing.Models
{
    public class Features
    {
        public int Id { get; set; }
         public bool PowerSteering { get; set; }

        public bool   Automatic { get; set; }
         public bool GPS { get; set; }

        public Model Model  {get;set;}
       public int ModelID { get; set; }
    }
}