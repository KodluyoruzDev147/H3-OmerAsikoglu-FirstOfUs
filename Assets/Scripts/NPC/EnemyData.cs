using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    [CreateAssetMenu(menuName = "Scriptable Objects/NPC/EnemyData")]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private readonly float movementSpeed;
        [SerializeField] private readonly float targetDetectDistance;
        [SerializeField] private readonly int enemyPoint;

        public float MovementSpeed => movementSpeed;
        public float TargetDetectDistance => targetDetectDistance;
        public int EnemyPoint => enemyPoint;
    }
}
