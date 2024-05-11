using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SmallScene_Quest_QuestableNPCs_QuestSystem : MonoBehaviour
{ 
    [SerializeField]
    public List<Quest> questList=new List<Quest>();
    public TMP_Text questText;

    void UpdateClues()
    {
        if (questList.Count!=0)
        {
            questText.text = questList[0].questText;
        }

    }
    private void Update()
    {
        UpdateClues();
    }
}
