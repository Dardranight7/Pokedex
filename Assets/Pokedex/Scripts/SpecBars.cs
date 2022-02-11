using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Dardra.Games.Pokedex
{
    public class SpecBars : MonoBehaviour
    {
        [SerializeField] Image Bar;
        [SerializeField] TextMeshProUGUI TextBar, TextValue;
        /// <summary>
        /// Fill bar depending percent of value by maxValue
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxValue"></param>
        public void FilledByValue(int value, int maxValue)
        {
            Bar.fillAmount = value / (float)maxValue;
            TextValue.text = value.ToString();
        }
    }
}