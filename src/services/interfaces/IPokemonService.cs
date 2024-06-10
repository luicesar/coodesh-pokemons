using domain.entities;

namespace services.interfaces
{
    public interface IPokemonService
    {
        Task<Pokemon> GetPokemonByIdAsync(int id);
    }
}
