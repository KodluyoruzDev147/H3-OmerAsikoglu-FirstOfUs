using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace FirstOfUs.UI
{
    public class ScoreUI : MonoBehaviour
    {
        public static ScoreUI Instance { get; private set; }

        [SerializeField] private Transform youWinUI;
        
        private TextMeshProUGUI textMesh;

        private int currentScore = 0;
        private const int maxScore = 6;

        private void Awake()
        {
            Instance = this;

            textMesh = transform.Find(StringData.BACKGROUND).Find(StringData.TEXT).GetComponent<TextMeshProUGUI>();
            youWinUI.gameObject.SetActive(false);

            UpdateScore();
        }

        public void UpdateScore(int amount = 0)
        {
            currentScore += amount;
            currentScore = Mathf.Clamp(currentScore, 0, maxScore);
            textMesh.SetText(currentScore.ToString() + " / " + maxScore.ToString());
            if (currentScore == maxScore)
            {
                youWinUI.gameObject.SetActive(true);
            }
        }

    }
}
