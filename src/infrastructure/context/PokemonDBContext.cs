using Microsoft.EntityFrameworkCore;
using domain.entities;

namespace infrastructure.context
{
    public class PokemonDBContext : DbContext
    {

        public PokemonDBContext(DbContextOptions<PokemonDBContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<CapturedPokemon> CapturedPokemons { get; set; }

    }
}
