using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ddo : MonoBehaviour
{
    //DD�ɂ������I�u�W�F�N�g�ɕt����
    //prefab�ɂ��āA�V�[�����ɒ��ڒu���Ȃ�����

    public static bool DontDestroyEnabled = true;

    private void Start()
    {
        if (DontDestroyEnabled)
        {
            // Scene��J�ڂ��Ă��I�u�W�F�N�g�������Ȃ��悤�ɂ���
            DontDestroyOnLoad(this);
            DontDestroyEnabled = false;
        }
    }
}
