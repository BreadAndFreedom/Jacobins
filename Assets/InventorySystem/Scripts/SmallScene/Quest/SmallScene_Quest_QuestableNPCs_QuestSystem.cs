using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SmallScene_Quest_QuestableNPCs_QuestSystem : MonoBehaviour
{ 
    [SerializeField]
    public List<Quest> questList=new List<Quest>();
    public List<TMP_Text> questTextList;

    public void UpdateClues()
    {
        if (questList.Count!=0)
        {
            int index = 0;
            foreach(var quest in questList)
            {
                questTextList[index].text = quest.questText;
                index++;
            }

        }

    }
}
