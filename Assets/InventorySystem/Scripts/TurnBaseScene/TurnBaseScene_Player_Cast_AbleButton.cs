using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBaseScene_Player_Cast_AbleButton : MonoBehaviour
{
    public List<Button> buttonList = new List<Button>();
    public void SetButtonAbled()
    {
        foreach (var button in buttonList)
        {
            button.interactable = true;
        }
    }
}
