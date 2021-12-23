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
        protected override void Awake()
        {
            base.Awake();
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void Update()
        {
            base.Update();
        }
        public PlayerControllerData GetPlayerData()
        {
            return playerData;
        }
    }

}