using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ddo : MonoBehaviour
{
    //DDにしたいオブジェクトに付ける
    //prefabにして、シーン内に直接置かないこと

    public static bool DontDestroyEnabled = true;

    private void Start()
    {
        if (DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
            DontDestroyEnabled = false;
        }
    }
}
