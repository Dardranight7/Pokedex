using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dardra.Games.Pokedex
{
    [CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/NewPokemon", order = 1)]
    public class Pokemon : ScriptableObject
    {
        public int pokedexNumber;
        public Sprite photo;
        public string pokemonName, species, description;
        public List<Enums.Types> pokemonTypes = new List<Enums.Types>();
        public List<string> abilities = new List<string>();
        public List<string> hiddenAbilities = new List<string>();
        public int hp, attack, defense, spAttack, spDefense, speed;
        public int maxHp, maxAttack, maxDefense, maxSpAttack, maxSpDefense, maxSpeed;
    }
}