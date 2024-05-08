using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class TurnBaseScene_Player_MainCharacter_SecondMenu : MonoBehaviour
{
    public List<GameObject> childs = new List<GameObject>();
    private bool isActive=false;
    // Start is called before the first frame update
    public void MakeChildVisible()
    {
        if(isActive==false)
        {
            isActive = true;
            Debug.Log("´ò¿ª");
            foreach(var child in childs)
            {
                child.SetActive(isActive);
            }
        }
        else if(isActive==true)
        {
            isActive = false;
            Debug.Log("¹Ø±Õ");
            foreach (var child in childs)
            {
                child.SetActive(isActive);
            }
        }
        
    }
}
