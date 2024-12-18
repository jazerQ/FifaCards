using System.Text.Json.Serialization;

namespace DataAccess
{
    public class FifaCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Skills? Skills { get; set; }
    }
}
