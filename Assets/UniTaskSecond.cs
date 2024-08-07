using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniTaskSecond : MonoBehaviour
{
    //TimeScale이 0일때도 동작
    //DelayType.UnscaledDeltaTime
    private async UniTaskVoid WaitSecond()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(1f), DelayType.UnscaledDeltaTime));
        Debug.Log("1");
    }

    void Start()
    {
        Time.timeScale = 0f;
        WaitSecond().Forget();
    }

}
