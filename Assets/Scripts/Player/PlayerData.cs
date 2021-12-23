using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.Player
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private float rotateSpeed;
        [SerializeField] private int maxMateCount = 6;

        public float RotateSpeed => rotateSpeed;
        public int MaxMateCount => maxMateCount;
    }
}
