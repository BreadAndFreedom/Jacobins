using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBaseScene_Player_Cast_DisableButton : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Button> buttonList = new List<Button>();
    public void SetButtonDisabled()
    {
        foreach (var button in buttonList)
        {
            button.interactable = false;
        }
    }
}
