using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dardra.Games.Pokedex
{
    public static class Utils
    {
        /// <summary>
        /// Return color of Type defined by programmer
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Color GetTypeColor(Enums.Types type)
        {
            switch (type)
            {
                case Enums.Types.Grass:
                        return Color.green;
                case Enums.Types.Poison:
                        return Color.magenta;
                case Enums.Types.Ghost:
                        return Color.black;
                case Enums.Types.Water:
                        return Color.blue;
                case Enums.Types.Fire:
                        return Color.red;
            }
            return Color.white;
        }
    }
}