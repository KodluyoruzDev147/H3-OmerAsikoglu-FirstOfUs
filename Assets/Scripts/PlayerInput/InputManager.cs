using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData inputData;

        private void Update()
        {
            ReceiveAxisInputs();
        }

        private void ReceiveAxisInputs()
        {
            inputData.horizontalInput = Input.GetAxisRaw(StringData.HORIZONTAL);
            inputData.verticalInput = Input.GetAxisRaw(StringData.VERTICAL);
            inputData.mouseInputX = Input.GetAxis(StringData.MOUSE_X);
            inputData.mouseInputY = Input.GetAxis(StringData.MOUSE_Y);
        }
    }
}
