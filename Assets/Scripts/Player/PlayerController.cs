using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstOfUs.PlayerInput;

namespace FirstOfUs.Player
{
    public class PlayerController : Model
    {
        [SerializeField] private PlayerControllerData playerData;
        [SerializeField] private InputData inputData;

        //private Vector3 screenPoint;
        public float rotatePosY;
        public float rotateSpeed;

        protected override void Awake()
        {
            base.Awake();

            //screenPoint = UnityEngine.Camera.main.WorldToScreenPoint(transform.localPosition);
            rotateSpeed = playerData.RotateSpeed;
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void Update()
        {
            base.Update();
            if (inputData.isClickingRight || inputData.horizontalInput < 0f)
            {
                //sola dön
                rotatePosY += rotateSpeed * Time.deltaTime;
                transform.Rotate(0, rotatePosY, 0);
            }
            else if (inputData.isClickingLeft || inputData.horizontalInput > 0f)
            {
                //saða dön
                rotatePosY += rotateSpeed * Time.deltaTime;
                transform.Rotate(0, -rotatePosY, 0);
            }
            else
            {
                rotatePosY = 0f;
            }
        }
    }

}