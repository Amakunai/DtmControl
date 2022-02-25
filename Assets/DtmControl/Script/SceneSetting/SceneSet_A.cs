using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneSet_A : MonoBehaviour
{
    //テストシーンA

    [SerializeField] private SceneLoader loader;
    [SerializeField] private Button SceneChange;

    private void Start()
    {
        SceneChange.onClick.AddListener(() =>loader.SceneLoad(SceneLoader.B));

        BgmManager.instance.SetBgm(BgmName.A_Scene);
    }
}
