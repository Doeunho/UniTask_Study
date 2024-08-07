using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class UniTaskStop : MonoBehaviour
{
    private CancellationTokenSource _source = new();

    private void Start()
    {
        Wait3Second().Forget();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _source.Cancel();
        }
    }

    private async UniTaskVoid Wait3Second()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(3), cancellationToken : _source.Token);
        Debug.Log("3√ ");
    }


}
