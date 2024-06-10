using domain.entities;
using services.interfaces;
using Newtonsoft.Json;

namespace services.service
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemonByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<dynamic>(content);

            var pokemon = new Pokemon
            {
                Id = data.id,
                Name = data.name,
                Sprite = data.sprites.front_default,
                Evolutions = new List<string>()
            };

            // Fetch evolutions...
            // Parse evolution chain here...

            return pokemon;
        }
    }
}
