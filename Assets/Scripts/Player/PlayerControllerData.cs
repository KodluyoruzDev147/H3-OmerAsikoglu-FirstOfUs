using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.Player
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player/PlayerControllerData")]
    public class PlayerControllerData : ScriptableObject
    {
        [SerializeField] private float rotateSpeed;
        
        public float RotateSpeed => rotateSpeed;
        
    }
}
