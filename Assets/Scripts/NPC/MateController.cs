using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstOfUs.Player;
using FirstOfUs.UI;

namespace FirstOfUs.NPC
{
    public class MateController : NPC
    {
        [SerializeField] private MateData mateData;
        protected override void Awake()
        {
            base.Awake();
            npcPoint = mateData.MatePoint;
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void Update()
        {
            base.Update();
        }

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
            PlayerStackController player = collision.gameObject.GetComponent<PlayerStackController>();
            if (player != null)
            {

                ScoreUI.Instance.UpdateScore(npcPoint);

                player.AddMate();

                Destroy(gameObject);
            }
        }
    }

}