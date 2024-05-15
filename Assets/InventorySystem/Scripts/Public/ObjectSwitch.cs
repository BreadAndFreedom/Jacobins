using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwitch : MonoBehaviour
{
    public List<GameObject> childs = new List<GameObject>();
    private bool isActive = false;
    // Start is called before the first frame update
    public void MakeChildVisible()
    {
        if (isActive == false)
        {
            isActive = true;
            Debug.Log("´ò¿ª");
            foreach (var child in childs)
            {
                child.SetActive(isActive);
            }
        }
        else if (isActive == true)
        {
            isActive = false;
            Debug.Log("¹Ø±Õ");
            foreach (var child in childs)
            {
                child.SetActive(isActive);
            }
        }

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            MakeChildVisible();
        }
    }
}
