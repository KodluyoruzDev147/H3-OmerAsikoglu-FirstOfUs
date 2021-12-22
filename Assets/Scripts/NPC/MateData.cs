using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    [CreateAssetMenu(menuName = "Scriptable Objects/NPC/MateData")]
    public class MateData : ScriptableObject
    {
        [SerializeField] private readonly float movementSpeed;
        [SerializeField] private readonly float targetDetectDistance;
        [SerializeField] private readonly int matePoint;

        public float MovementSpeed => movementSpeed;  // get { return movementSpeed;}
        public float TargetDetectDistance => targetDetectDistance;
        public int MatePoint => matePoint;

    }

}