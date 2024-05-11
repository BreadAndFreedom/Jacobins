using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseScene_DIalog_Dialog_DialogManager : MonoBehaviour
{
    public List<GameObject> dialogList = new List<GameObject>();
    private int index = 0;
    // Start is called before the first frame update

    public void ShowNextDialog()
    {
        foreach(var dialog in dialogList)
        {
            dialog.SetActive(false);
        }
        dialogList[index].SetActive(true);
        index++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ShowNextDialog();
        }
    }
}
