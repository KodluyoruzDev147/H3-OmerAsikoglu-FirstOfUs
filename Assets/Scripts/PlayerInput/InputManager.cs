using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.PlayerInput
{
    //TODO: Add Mobile Input System
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData inputData;

        private void Update()
        {
            ReceiveAxisInputs();
            ReceiveClickInput();
        }

        private void ReceiveClickInput()
        {
            inputData.isClickingRight = Input.GetMouseButton(1);
            inputData.isClickingLeft = Input.GetMouseButton(0);
        }

        private void ReceiveAxisInputs()
        {
            inputData.horizontalInput = Input.GetAxisRaw(StringData.HORIZONTAL);
            inputData.verticalInput = Input.GetAxisRaw(StringData.VERTICAL);
        }
    }
}
