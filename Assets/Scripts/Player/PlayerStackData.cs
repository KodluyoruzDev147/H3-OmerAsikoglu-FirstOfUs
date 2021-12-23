using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.Player
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player/PlayerStackData")]
    public class PlayerStackData : ScriptableObject
    {
        [SerializeField] private int maxMateCount = 6;

        public int MaxMateCount => maxMateCount;
    }

}