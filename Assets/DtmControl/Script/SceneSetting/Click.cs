using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    //Seを鳴らすときのサンプル

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(ClickOneShot);
    }

    private void ClickOneShot() 
    {
        //この一文でどこからでも呼べる
        SeManager.instance.PlayOneShot(SeName.click);
    }
}
