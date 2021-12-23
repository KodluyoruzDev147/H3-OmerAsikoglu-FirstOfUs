using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.AI
{
    [CreateAssetMenu(menuName = "Scriptable Objects/AI/NPCWaveData")]
    public class NPCWaveData : ScriptableObject
    {
        [SerializeField] private int totalWaveNumber = 5;
        [SerializeField] private int amountOfEnemyPerSpawn;
        [SerializeField] private float enemySpawnTimerMax;

        public int TotalWaveNumber => totalWaveNumber;
        public int AmountOfEnemyPerSpawn => amountOfEnemyPerSpawn;
        public float EnemySpawnTimerMax => enemySpawnTimerMax;
        private void OnEnable()
        {
            amountOfEnemyPerSpawn = UnityEngine.Random.Range(1, 3);
        }
    }

}