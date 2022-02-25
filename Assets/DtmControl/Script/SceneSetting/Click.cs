using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    //Se��炷�Ƃ��̃T���v��

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(ClickOneShot);
    }

    private void ClickOneShot() 
    {
        //���̈ꕶ�łǂ�����ł��Ăׂ�
        SeManager.instance.PlayOneShot(SeName.click);
    }
}
