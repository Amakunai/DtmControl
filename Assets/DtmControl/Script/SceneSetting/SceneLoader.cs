using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //scene�J�ڂ��邾��
    public const string A = "DtmTestSceneA";
    public const string B = "DtmTestSceneB";


    public void SceneLoad(string name) 
    {
        SceneManager.LoadScene(name);
    }
}
