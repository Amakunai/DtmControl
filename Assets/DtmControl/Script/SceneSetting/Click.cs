using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    //Se‚ð–Â‚ç‚·‚Æ‚«‚ÌƒTƒ“ƒvƒ‹

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(ClickOneShot);
    }

    private void ClickOneShot() 
    {
        //‚±‚Ìˆê•¶‚Å‚Ç‚±‚©‚ç‚Å‚àŒÄ‚×‚é
        SeManager.instance.PlayOneShot(SeName.click);
    }
}
