using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    public class MateController : NPC
    {
        [SerializeField] private MateData mateData;
        protected override void Awake()
        {
            base.Awake();
            SetNPCPoint(mateData.MatePoint);
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

                UI.ScoreUI.Instance.ChangeScore(npcPoint);

                player.AddMate();

                Destroy(gameObject);
            }
        }
    }

}