using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    [CreateAssetMenu(menuName = "Scriptable Objects/NPC/MateData")]
    public class MateData : ScriptableObject
    {
        [SerializeField] private float movementSpeed; // 0 means randomValue
        [SerializeField] private float targetDetectDistance;
        [SerializeField] private int matePoint = 1;

        public float MovementSpeed => movementSpeed;  // get { return movementSpeed;}
        public float TargetDetectDistance => targetDetectDistance;
        public int MatePoint => matePoint;

    }

}