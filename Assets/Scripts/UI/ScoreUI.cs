using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace FirstOfUs.UI
{
    public class ScoreUI : MonoBehaviour
    {
        public static ScoreUI Instance { get; private set; }

        private int totalScore = 0;


        //private static ScoreUI instance;
        //public static ScoreUI Instance => instance ?? (instance = new MySingleton());

        private void Awake()
        {
            Instance = this;
        }

        public void ChangeScore(int amount)
        {
            totalScore += amount;
        }

    }
}
