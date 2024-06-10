using System.Collections.Generic;

namespace domain.entities
{
    public class CapturedPokemon
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public int PokemonId { get; set; }
        public DateTime CaptureDate { get; set; }
    }
}
