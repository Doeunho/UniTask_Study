using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UniTaskWebImg : MonoBehaviour
{
    private const string Apple = "https://mblogthumb-phinf.pstatic.net/MjAyMTA0MzBfMjY5/MDAxNjE5NzE3NzI3NzA0.pRjLQmj3j-WJw_VsB3462ei_jtPZBQoEqeZMefFrx78g.NrqN4kOi0JIOd-LrJOmbhXY4dFk9UE7gcptxxwSzRw0g.PNG.chomchom64/image.png?type=w800";
    public RawImage profileIme;

    private async UniTask<Texture2D> WaitWebImg()
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(Apple);
        await request.SendWebRequest();

        if(request.result is UnityWebRequest.Result.ConnectionError or UnityWebRequest.Result.ProtocolError)
        {
            //角菩贸府
            Debug.LogError(request.error);
        }
        else
        {
            //己傍贸府
            Texture2D texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            return texture;
        }

        return null;
    }

    private async UniTaskVoid GetImg()
    {
        Texture2D texture = await WaitWebImg();
        profileIme.texture = texture;
    }


    void Start()
    {
        GetImg().Forget();
    }

}
