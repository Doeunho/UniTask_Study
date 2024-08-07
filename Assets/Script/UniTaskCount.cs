using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniTaskCount : MonoBehaviour
{

    public int _count;

    private async UniTaskVoid WaitCount()
    {
        await UniTask.WaitUntil(() => _count == 3);
        Debug.Log("Count = 3");
    }

    void Start()
    {
        WaitCount().Forget();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _count++;
        }
    }

}
