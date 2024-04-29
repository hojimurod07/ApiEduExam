
namespace Domain.Entities
{
    public  class Fan:BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Spiker { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public double Price {  get; set; }
        public List<string> Topics { get; set; } = new List<string>();  
    }

}
