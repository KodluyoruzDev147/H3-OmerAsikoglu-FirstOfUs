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
        }

        protected override void Update()
        {
            base.Update();
            transform.Translate(moveDirection * Time.deltaTime);
        }

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
        }
    }

}