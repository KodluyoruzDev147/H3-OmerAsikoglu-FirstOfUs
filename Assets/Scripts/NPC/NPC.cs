using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstOfUs.Player;

namespace FirstOfUs.NPC
{
    public class NPC : Model
    {
        [SerializeField] protected Transform targetTransform;

        protected Vector3 moveDirection;

        protected int npcPoint; //could be negative

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void Start()
        {
            base.Start();
            SetDirection();
        }

        protected override void Update()
        {
            base.Update();
        }

        private void SetDirection()
        {
            moveDirection = (targetTransform.position - transform.position).normalized;


        }
        protected void SetNPCPoint(int amount = 0)
        {
            npcPoint = amount;
        }
        protected virtual void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {

                UI.ScoreUI.Instance.ChangeScore(npcPoint);

                //TODO: Add mate to your back

                Destroy(gameObject);
            }

        }

    }
}
