using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update

    public void OnTriggerStay(Collider other)
    {
        //Debug.Log("大熊，我要进来了");
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void OnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}


