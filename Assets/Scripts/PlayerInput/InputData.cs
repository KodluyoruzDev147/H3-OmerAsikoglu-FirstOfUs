using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.PlayerInput
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Input/Data")]
    public class InputData : ScriptableObject
    {
        public float horizontalInput;
        public float verticalInput;

        public bool isClickingRight;
        public bool isClickingLeft;

    } 
}
