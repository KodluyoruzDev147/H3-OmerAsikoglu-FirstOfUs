using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstOfUs.Player
{
    public class PlayerStackController : MonoBehaviour
    {
        [SerializeField] private PlayerData playerData;

        private Dictionary<int, Transform> mateStackDic; // [index, childTransform] => index starting from 1 bcs equal to activeMateCount

        private int activeMateCount = 0;

        private void Awake()
        {
            mateStackDic = new Dictionary<int, Transform>();

            InitMateStack();
        }

        private void InitMateStack()
        {
            Transform mateTransform = transform.Find(StringData.STACK);

            int index = 1;
            foreach (Transform mate in mateTransform)
            {
                mateStackDic[index] = mate;
                index++;
                mate.gameObject.SetActive(false);
            }
        }

        public void AddMate()
        {
            if (activeMateCount <= playerData.MaxMateCount)
            {
                activeMateCount++;
                AddMateToStack();
            }
        }
        private void AddMateToStack()
        {
            if (mateStackDic.ContainsKey(activeMateCount))
            {
                mateStackDic[activeMateCount].gameObject.SetActive(true);
            }
        }
        public void RemoveMate()
        {
            if (activeMateCount > 0)
            {
                activeMateCount--;
                RemoveMateFromStack();
            }
        }
        private void RemoveMateFromStack()
        {
            if (mateStackDic.ContainsKey(activeMateCount + 1))
            {
                mateStackDic[activeMateCount + 1].gameObject.SetActive(false);
            }
        }
    }
}
