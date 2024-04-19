using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBaseScene_Player_MainCharacter_Cast : MonoBehaviour
{
    [Serializable]
    public struct DialogTable
    {
        public List<int> nextDialog;
        public string content;
        public Text textLabel;
    }

    public DialogTable[] dialogTable;

    private void Start()
    {
        foreach(DialogTable dialog in dialogTable)
        {
            dialog.textLabel.text = dialog.content;
        }
    }
    void Click()
    {
        
    }
}
