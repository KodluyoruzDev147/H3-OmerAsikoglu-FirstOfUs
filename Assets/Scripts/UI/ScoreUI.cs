using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.UI
{
    public class ScoreUI : MonoBehaviour
    {
        public static ScoreUI Instance { get; private set; }

        //private static ScoreUI instance;
        //public static ScoreUI Instance => instance ?? (instance = new MySingleton());

        private void Awake()
        {
            Instance = this;
        }
    }
}
