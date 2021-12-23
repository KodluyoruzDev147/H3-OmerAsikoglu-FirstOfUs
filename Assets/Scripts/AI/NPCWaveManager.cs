using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.AI
{
    public class NPCWaveManager : MonoBehaviour
    {
        [SerializeField] private NPCWaveData waveData;

        [SerializeField] private List<Transform> NPCList;
        [SerializeField] private List<Transform> spawnPosList;

        private float currentTimer;

        private void Awake()
        {
            currentTimer = waveData.NPCSpawnTimerMax;
            SpawnNPCs();
        }
        private void Update()
        {
            currentTimer -= Time.deltaTime;
            if (currentTimer <= 0f)
            {
                SpawnNPCs();
                currentTimer = waveData.NPCSpawnTimerMax;
            }
        }
        private void SpawnNPCs()
        {
            for (int i = 0; i < waveData.AmountOfEnemyPerSpawn; i++)
            {
                int indexNPC = GetRandomNumber(0, 11) > 3 ? 0 : 1;
                int indexSpawnPos = GetRandomNumber(0, spawnPosList.Count);
                Instantiate(NPCList[indexNPC], spawnPosList[indexSpawnPos].position, Quaternion.identity, transform);
            }
        }

        private int GetRandomNumber(int min, int max)
        {
            return UnityEngine.Random.Range(min, max);
        }
    }
}
