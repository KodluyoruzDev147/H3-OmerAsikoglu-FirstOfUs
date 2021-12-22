using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    [CreateAssetMenu(menuName = "Scriptable Objects/NPC/EnemyData")]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private readonly float movementSpeed;

        public float MovementSpeed => movementSpeed;
    } 
}
