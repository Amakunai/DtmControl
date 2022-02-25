using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneSet_B : MonoBehaviour
{
    //テストシーンB

    [SerializeField] private SceneLoader loader;
    [SerializeField] private Button SceneChange;

    private void Start()
    {
        SceneChange.onClick.AddListener(() => loader.SceneLoad(SceneLoader.A));

        BgmManager.instance.SetBgm(BgmName.B_Scene);

    }
}
