using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnBaseScene_Player_MainCharacter_Cast : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("�ı�")]
    public TextAsset textFile;

    [Header("��Ϸ����")]
    public GameObject dialogBackground;//����Ԥ����
    public TMP_Text dialogContent;//�ı���Ԥ����
    [Header("��ɫ��������Ϸ�����Ӧ")]
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
                    if (cells[2] == dialog.identify)//ͨ��idѰַ���ҵ���Ӧ�Ķ���
                    {
                        if (dialog.isSettled == false)//�ж��Ƿ����ɹ��Ի�����ı���������Ϻ���Ϊtrue
                        {
                            dialogs[dialog.index].panel = Instantiate(dialogBackground, characters[dialog.index].transform, true);
                            dialogs[dialog.index].text = Instantiate(dialogContent, characters[dialog.index].transform, true);
                            dialogs[dialog.index].isSettled = true;
                        }
                        dialogs[dialog.index].text.text = cells[3];//�����ı�
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

