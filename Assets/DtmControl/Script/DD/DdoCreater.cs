using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DdoCreater : MonoBehaviour
{
    //DDO(Don't Destory Object)�𐶐�����
    //�S�ẴV�[���ɒu�����ƂŁA�ǂ̃V�[������n�߂Ă��Ȃ������

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
