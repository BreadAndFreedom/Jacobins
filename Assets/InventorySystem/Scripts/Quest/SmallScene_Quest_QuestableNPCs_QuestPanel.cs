using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_Quest_QuestableNPCs_QuestPanel : MonoBehaviour
{
    public GameObject questPanel;
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isActive==false&&Input.GetKeyDown(KeyCode.E))
        {
            isActive = true;
            questPanel.SetActive(isActive);
        }
        else if (isActive == true && Input.GetKeyDown(KeyCode.E))
        {
            isActive = false;
            questPanel.SetActive(isActive);
        }
    }
}
