using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dardra.Games.Pokedex
{
    public class KeepAspect : MonoBehaviour
    {
        [SerializeField] GridLayoutGroup gridLayout;
        float originalWidth;

        void Start()
        {
            ChangeGrid();
            originalWidth = Screen.width;
        }

        void Update()
        {
            if (originalWidth != Screen.width)
            {
                ChangeGrid();
                originalWidth = Screen.width;
            }
        }
        /// <summary>
        /// Change the grid layout count depending of screen width
        /// </summary>
        public void ChangeGrid()
        {
            if (Screen.width > Screen.height)
            {
                gridLayout.constraintCount = 2;
            }
            else
            {
                gridLayout.constraintCount = 1;
            }
        }
    }
}