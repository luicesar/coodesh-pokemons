using System.Collections.Generic;

namespace domain.entities {
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sprite { get; set; }
        public List<string> Evolutions { get; set; }
    }
}
