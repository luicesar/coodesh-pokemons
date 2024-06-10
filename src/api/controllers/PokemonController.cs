using services.interfaces;
using domain.entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pokemon = await _pokemonService.GetPokemonByIdAsync(id);
            if (pokemon == null)
                return NotFound();

            return Ok(pokemon);
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandom()
        {
            var randomIds = new List<int>();
            randomIds.Add(1);
            randomIds.Add(2);
            randomIds.Add(3);
            randomIds.Add(4);
            randomIds.Add(5);
            randomIds.Add(6);
            randomIds.Add(7);
            randomIds.Add(8);
            randomIds.Add(9);
            randomIds.Add(10);
            randomIds.Add(11);
            randomIds.Add(12);
            randomIds.Add(13);

            var pokemons = new List<Pokemon>();

            foreach (var id in randomIds)
            {
                var pokemon = await _pokemonService.GetPokemonByIdAsync(id);
                pokemons.Add(pokemon);
            }

            return Ok(pokemons);
        }
    }
}
