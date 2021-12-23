using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FirstOfUs.NPC
{
    public class NPC : Model
    {
        [SerializeField] protected Transform targetTransform;
        private float moveSpeed;

        protected Vector3 moveDirection;

        protected int npcPoint; //could be negative

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void Start()
        {
            base.Start();

            if (targetTransform == null)
            {
                targetTransform = GameObject.Find(StringData.PLAYER).transform;
            }
            SetDirection();
            GetRandomMoveSpeed();

        }

        private void GetRandomMoveSpeed()
        {
            moveSpeed = UnityEngine.Random.Range(0, 2) < 1 ? 2f : 4f;
        }

        protected override void Update()
        {
            base.Update();
            transform.Translate(moveSpeed * moveDirection * Time.deltaTime);
        }

        protected void SetDirection()
        {
            moveDirection = (targetTransform.position - transform.position).normalized;


        }
        protected void SetMoveSpeed(float amount)
        {
            moveSpeed = amount;
        }
        protected virtual void OnCollisionEnter(Collision collision)
        {
            

        }

    }
}
