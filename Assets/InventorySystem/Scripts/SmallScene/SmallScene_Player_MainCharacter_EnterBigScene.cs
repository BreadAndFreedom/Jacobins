using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallScene_Player_MainCharacter_EnterBigScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        //Debug.Log("大熊，我要进来了");
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("E0P2");
        }
    }
}
