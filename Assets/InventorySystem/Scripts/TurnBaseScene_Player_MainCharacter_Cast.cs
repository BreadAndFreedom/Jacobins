using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnBaseScene_Player_MainCharacter_Cast : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("文本")]
    public TextAsset textFile;

    [Header("游戏物体")]
    public GameObject dialogBackground;//面板的预制体
    public TMP_Text dialogContent;//文本的预制体
    [Header("角色名称与游戏物体对应")]
    public List<string> names = new List<string>();
    public List<GameObject> characters = new List<GameObject>();


    private string[] dialogRows;
    private int dialogIndex = 1;
    private List<Dialog> dialogs = new List<Dialog>();
    private bool isSettled = false;


    public void DialogModule()
    {
        InitializeObjects();
        GetTextFromFile();
        ShowDialogRow();
    }
    void GetTextFromFile()
    {
        dialogRows = textFile.text.Split('\n');
        Debug.Log(dialogRows[dialogIndex]);
    }

    public void ShowDialogRow()
    {
        foreach (var row in dialogRows)
        {
            //textList.Add(cell);
            string[] cells = row.Split(',');
            if (cells[0] == "#" && int.Parse(cells[1]) == dialogIndex)
            {
                foreach (var dialog in dialogs)
                {
                    if (cells[2] == dialog.identify)//通过id寻址，找到对应的对象
                    {
                        if (dialog.isSettled == false)//判定是否生成过对话框和文本，生成完毕后设为true
                        {
                            dialogs[dialog.index].panel = Instantiate(dialogBackground, characters[dialog.index].transform, true);
                            dialogs[dialog.index].text = Instantiate(dialogContent, characters[dialog.index].transform, true);
                            dialogs[dialog.index].isSettled = true;
                        }
                        dialogs[dialog.index].text.text = cells[3];//更新文本
                    }
                }
                dialogIndex = int.Parse(cells[4]);
                break;
            }

            else if (cells[0] == "END")
            {
                foreach (var dialog in dialogs)
                {
                    Destroy(dialog.panel);
                    Destroy(dialog.text);
                }
            }
        }
    }
    public void OnClickNext()
    {
        if (isSettled == false)
        {
            DialogModule();
            isSettled = true;
        }
        else
        {
            ShowDialogRow();
        }

    }
    //public void GenerateDialogBackground()
    //{
    //    dialogUI=Instantiate(dialogBackground, speakerCanva.transform,true);
    //}

    //public void GenerateDialogText()
    //{
    //    dialogText = Instantiate(dialogContent, speakerCanva.transform, true);
    //}

    public void InitializeObjects()
    {
        int index = 0;
        foreach (var name in names)
        {
            Dialog dialog = new Dialog();
            dialog.identify = name;
            dialog.index = index;
            dialog.isSettled = false;
            index++;
            dialogs.Add(dialog);
        }
        foreach (var dialog in dialogs)
        {
            Debug.Log(dialog.identify);
            Debug.Log(dialog.index);
        }
    }

    public class Dialog
    {
        public TMP_Text text;
        public GameObject panel;
        public bool isSettled;
        public string identify;
        public int index;

    }
}

