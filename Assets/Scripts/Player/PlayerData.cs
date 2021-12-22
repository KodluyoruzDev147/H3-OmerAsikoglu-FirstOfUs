using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.Player
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private readonly float movementSpeed;
        public float MovementSpeed => movementSpeed;
    } 
}
