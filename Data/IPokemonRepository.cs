using PokemonReview.Models;

namespace PokemonReview.Data
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}