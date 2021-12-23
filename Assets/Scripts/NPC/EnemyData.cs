using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    [CreateAssetMenu(menuName = "Scriptable Objects/NPC/EnemyData")]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private float movementSpeed; // 0 means randomValue
        [SerializeField] private float targetDetectDistance;
        [SerializeField] private int enemyPoint = -1;
        [SerializeField] private const float directionCheckTimeMax = 5f;

        public float MovementSpeed => movementSpeed;
        public float TargetDetectDistance => targetDetectDistance;
        public int EnemyPoint => enemyPoint;
        public float DirectionCheckTimeMax => directionCheckTimeMax;
    }
}
