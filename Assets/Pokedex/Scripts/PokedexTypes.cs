using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Dardra.Games.Pokedex
{
    public class PokedexTypes : MonoBehaviour
    {
        [SerializeField] Image backgroundColor;
        [SerializeField] TextMeshProUGUI textType;
        /// <summary>
        /// Display name of type and color
        /// </summary>
        /// <param name="type"></param>
        public void SetData(Enums.Types type)
        {
            backgroundColor.color = Utils.GetTypeColor(type);
            textType.text = type.ToString();
        }
    }
}