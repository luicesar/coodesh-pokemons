using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using domain.entities;
using services.interfaces;
using infrastructure.context;

namespace api.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainerController : ControllerBase
    {
        private readonly PokemonDBContext _context;

        public TrainerController(PokemonDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainer([FromBody] Trainer trainer)
        {
            _context.Trainers.Add(trainer);
            await _context.SaveChangesAsync();
            return Ok(trainer);
        }

        [HttpPost("{trainerId}/capture/{pokemonId}")]
        public async Task<IActionResult> CapturePokemon(int trainerId, int pokemonId)
        {
            var capturedPokemon = new CapturedPokemon
            {
                TrainerId = trainerId,
                PokemonId = pokemonId,
                CaptureDate = DateTime.UtcNow
            };

            _context.CapturedPokemons.Add(capturedPokemon);
            await _context.SaveChangesAsync();

            return Ok(capturedPokemon);
        }

        [HttpGet("{trainerId}/captured")]
        public async Task<IActionResult> GetCapturedPokemons(int trainerId)
        {
            var capturedPokemons = await _context.CapturedPokemons
                .Where(cp => cp.TrainerId == trainerId)
                .ToListAsync();

            return Ok(capturedPokemons);
        }
    }
}
