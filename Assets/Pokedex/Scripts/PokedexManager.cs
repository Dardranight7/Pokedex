using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dardra.Games.Pokedex
{
    public class PokedexManager : MonoBehaviour
    {
        [SerializeField] List<Pokemon> Pokemons = new List<Pokemon>();
        [SerializeField] PokedexView pokedexView;
        int currentIndex;

        void Start()
        {
            Pokemons = new List<Pokemon>(Resources.LoadAll<Pokemon>("Pokemons"));
            LoadData(0);
        }
        /// <summary>
        /// Search pokemonName in pokemons list
        /// </summary>
        /// <param name="pokemonName"></param>
        public void FindIndex(string pokemonName)
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                if (Pokemons[i].pokemonName.Contains(pokemonName))
                {
                    currentIndex = i;
                    LoadData(i);
                    return;
                }
            }
        }
        /// <summary>
        /// Change the index to next
        /// </summary>
        public void NextPokemon()
        {
            currentIndex = currentIndex + 1 > Pokemons.Count - 1 ? 0 : currentIndex + 1;
            LoadData(currentIndex);
        }
        /// <summary>
        /// Change the index to back
        /// </summary>
        public void BackPokemon()
        {
            currentIndex = currentIndex - 1 < 0 ? Pokemons.Count - 1 : currentIndex - 1;
            LoadData(currentIndex);
        }
        /// <summary>
        /// Call show information from pokedex view
        /// </summary>
        /// <param name="index"></param>
        public void LoadData(int index)
        {
            pokedexView?.ShowInformation(Pokemons[index]);
        }
    }
}