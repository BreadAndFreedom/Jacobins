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
    //public GameObject camera;
    public GameObject healthManager;
    [Header("角色名称与游戏物体对应")]
    public List<string> names = new List<string>();
    public List<GameObject> characters = new List<GameObject>();
    public List<TMP_Text> texts = new List<TMP_Text>();


    private string[] dialogRows;
    private int dialogIndex = 1;
    private List<Dialog> dialogs = new List<Dialog>();
    private bool isSettled = false;
    private bool hasEnd = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&&hasEnd==false)
        {
            OnClickNext();
        }
    }
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
                        if (dialog.isActive == false)//判定是否生成过对话框和文本，生成完毕后设为true
                        {
                            characters[dialog.index].SetActive(true);
                            dialogs[dialog.index].isActive = true;
                        }
                        dialogs[dialog.index].text.text = cells[3];//更新文本
                    }

                }
                dialogIndex = int.Parse(cells[4]);
                break;
            }

            else if (cells[0] == "END")
            {
                foreach (var canva in characters)
                {
                    canva.SetActive(false);
                    
                }
                hasEnd = true;
            }
            else if (cells[0] == "&")
            {

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

    public void InitializeObjects()
    {
        int index = 0;
        foreach (var name in names)
        {
            Dialog dialog = new Dialog();
            dialog.identify = name;
            dialog.index = index;
            dialog.isActive = false;
            dialog.text = texts[index];
            index++;
            dialogs.Add(dialog);
        }
        
    }
   

    public class Dialog
    {
        public TMP_Text text;//用于更新文本
        public bool isActive;//用于判断对话框是否显示
        public string identify;
        public int index;

    }
}

