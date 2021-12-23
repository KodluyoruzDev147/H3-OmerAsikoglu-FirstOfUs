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

        private float currentDirectionCheckTime;
        protected override void Awake()
        {
            base.Awake();
            npcPoint = mateData.MatePoint;
            currentDirectionCheckTime = mateData.DirectionCheckTimeMax;
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void Update()
        {
            base.Update();
            currentDirectionCheckTime -= Time.deltaTime;
            if (currentDirectionCheckTime <= 0f)
            {
                SetDirection();
                currentDirectionCheckTime = mateData.DirectionCheckTimeMax;
            }

        }

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
            PlayerStackController player = collision.gameObject.GetComponent<PlayerStackController>();

            if (collision.collider.GetType() == typeof(BoxCollider) && player != null)
            {
                ScoreUI.Instance.UpdateScore(npcPoint);
                collision.gameObject.GetComponent<PlayerStackController>().AddMate();
                Destroy(gameObject);
            }
            if (collision.collider.GetType() == typeof(CapsuleCollider) && player != null)
            {
                SetDirectionReverse();
                Destroy(gameObject, 5f);
            }
        }
    }

}