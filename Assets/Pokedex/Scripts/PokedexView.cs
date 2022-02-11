using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Dardra.Games.Pokedex
{
    public class PokedexView : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI pokemonName, number, species, description, abilities, hiddenAbilities;
        [SerializeField] Image pokemonPhoto;
        [SerializeField] GameObject typeContainer, typePrefab;
        [SerializeField] List<PokedexTypes> instancedTypes;
        [SerializeField] List<SpecBars> specBars;
        [SerializeField] TMP_InputField searchInput;
        [SerializeField] PokedexManager pokedexManager;
        string searchingPokemon = "";
        /// <summary>
        /// Get all data from Pokemon and display them
        /// </summary>
        /// <param name="pokemon"></param>
        public void ShowInformation(Pokemon pokemon)
        {
            pokemonName.text = pokemon.name;
            number.text = pokemon.pokedexNumber.ToString("#000");
            species.text = pokemon.species;
            description.text = pokemon.description;
            abilities.text = pokemon.abilities[0];
            hiddenAbilities.text = pokemon.hiddenAbilities[0];
            pokemonPhoto.sprite = pokemon.photo;
            for (int i = 0; i < instancedTypes.Count; i++)
            {
                instancedTypes[i].gameObject.SetActive(false);
            }
            for (int i = 0; i < pokemon.pokemonTypes.Count; i++)
            {
                if (i > instancedTypes.Count - 1)
                {
                    instancedTypes.Add(Instantiate(typePrefab, typeContainer.transform).GetComponent<PokedexTypes>());
                }
                instancedTypes[i].SetData(pokemon.pokemonTypes[i]);
                instancedTypes[i].gameObject.SetActive(true);
            }
            specBars[0].FilledByValue(pokemon.hp, pokemon.maxHp);
            specBars[1].FilledByValue(pokemon.attack, pokemon.maxAttack);
            specBars[2].FilledByValue(pokemon.defense, pokemon.maxDefense);
            specBars[3].FilledByValue(pokemon.spAttack, pokemon.maxSpAttack);
            specBars[4].FilledByValue(pokemon.spDefense, pokemon.maxSpDefense);
            specBars[5].FilledByValue(pokemon.speed, pokemon.maxSpeed);
            specBars[6].FilledByValue(pokemon.hp + pokemon.attack + pokemon.defense + pokemon.spAttack + pokemon.spDefense + pokemon.speed, 100);
        }
        /// <summary>
        /// Change the value of searchingPokemon
        /// </summary>
        /// <param name="msg"></param>
        public void SetSearchingPokemon(string msg)
        {
            searchingPokemon = msg;
        }
        /// <summary>
        /// Search and set index of contain name pokemon in searchingPokemon var
        /// </summary>
        public void SearchCurrent()
        {
            pokedexManager.FindIndex(searchingPokemon);
        }
    }
}