using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DdoCreater : MonoBehaviour
{
    //DDO(Don't Destory Object)を生成する
    //全てのシーンに置くことで、どのシーンから始めても曲が流れる

    private static bool isCreate = true;
    [SerializeField] private GameObject DDO;


    private void Awake()
    {
        if (isCreate)
        {
            isCreate = false;

            Instantiate(DDO);

        }
    }

}
