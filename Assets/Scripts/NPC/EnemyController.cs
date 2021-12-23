using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.NPC
{
    public class EnemyController : NPC
    {
        [SerializeField] private EnemyData enemyData;
        protected override void Awake()
        {
            base.Awake();
            SetNPCPoint(enemyData.EnemyPoint);
        }

        protected override void Start()
        {
            base.Start();

            if (enemyData.MovementSpeed != 0)
            {
                SetMoveSpeed(enemyData.MovementSpeed);
            }
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

                player.RemoveMate();

                Destroy(gameObject);
            }
        }
    }

}