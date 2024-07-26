using System.ComponentModel.DataAnnotations;

namespace PersonalProjectAPI.Entities
{
    public class Stand
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public char Power { get; set; }

        public char Speed { get; set; }

        public char Range { get; set; }

        public char Persistence { get; set; }

        public char Precision { get; set; }

        public char Potential { get; set; }
        public byte[]? Img {get; set;}
    }
}
