using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    [CreateAssetMenu(menuName = "Scriptable Objects/NPC/MateData")]
    public class MateData : ScriptableObject
    {
        [SerializeField] private readonly float movementSpeed;

        public float MovementSpeed => movementSpeed;  // get { return movementSpeed;}

    }

}