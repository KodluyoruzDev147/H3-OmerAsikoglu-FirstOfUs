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
        [SerializeField] private const float npcSpawnTimerMax = 2f;

        public int TotalWaveNumber => totalWaveNumber;
        public int AmountOfEnemyPerSpawn => amountOfEnemyPerSpawn;
        public float NPCSpawnTimerMax => npcSpawnTimerMax;
        private void OnEnable()
        {
            amountOfEnemyPerSpawn = UnityEngine.Random.Range(1, 3);
        }
    }

}