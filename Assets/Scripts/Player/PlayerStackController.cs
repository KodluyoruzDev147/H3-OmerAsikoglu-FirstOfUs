using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStackController : MonoBehaviour
{
    private Dictionary<int, Transform> mateStackDic;
    
    private const int maxMateCount = 6;
    private int activeMateCount = 0;
    
    private void Awake()
    {
        mateStackDic = new Dictionary<int, Transform>(); // 1-2...-6 

        InitMateStack();
    }

    private void InitMateStack()
    {
        Transform mateTransform = transform.Find(StringData.STACK);

        int i = 1;
        foreach (Transform mate in mateTransform)
        {
            mateStackDic[i] = mate;
            i++;
            mate.gameObject.SetActive(false);
        }
    }

    public void AddMate()
    {
        activeMateCount++;
        if (activeMateCount <= maxMateCount)
        {
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
