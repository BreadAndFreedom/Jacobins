using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseScene_Player_MainCharacter_SecondMenu : MonoBehaviour
{
    public GameObject secondMenu;
    private bool isActive=false;
    // Start is called before the first frame update
    public void MakeChildVisible()
    {
        if(isActive==false)
        {
            Debug.Log("´ò¿ª");
            isActive = true;
            secondMenu.SetActive(isActive);
        }
        else if(isActive==true)
        {
            Debug.Log("¹Ø±Õ");
            isActive = false;
            secondMenu.SetActive(isActive);
        }
        
    }
}
