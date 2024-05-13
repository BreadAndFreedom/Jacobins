using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        gameObject.SetActive(true);
    }

    public void SetDialogActive(GameObject dialog)
    {
        dialog.SetActive(true);
    }
    
    public void FindObject(string name)
    {
        if (GameObject.Find(name) != null)
        {
            Debug.Log("ур╣╫ак");
        }

    }
}
