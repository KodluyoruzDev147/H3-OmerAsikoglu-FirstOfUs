using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstOfUs.Player;
using FirstOfUs.UI;

namespace FirstOfUs.NPC
{
    public class EnemyController : NPC
    {
        [SerializeField] private EnemyData enemyData;

        private float currentDirectionCheckTime;
        protected override void Awake()
        {
            base.Awake();
             npcPoint = enemyData.EnemyPoint;
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
            currentDirectionCheckTime -= Time.deltaTime;
            if (currentDirectionCheckTime <= 0f)
            {
                SetDirection();
                currentDirectionCheckTime = enemyData.DirectionCheckTimeMax;
            }
        }

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
            PlayerStackController player = collision.gameObject.GetComponent<PlayerStackController>();
            if (player != null)
            {

                ScoreUI.Instance.UpdateScore(npcPoint);

                player.RemoveMate();

                Destroy(gameObject);
            }
        }
    }

}