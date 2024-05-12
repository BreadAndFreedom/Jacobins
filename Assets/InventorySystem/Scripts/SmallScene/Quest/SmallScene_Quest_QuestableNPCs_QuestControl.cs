using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_Quest_QuestableNPCs_QuestControl : MonoBehaviour
{
    [SerializeField]
    public Quest newQuest;
    public GameObject questManager;
    public GameObject dialog;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void CompeleteQuest()
    {
        newQuest.isFinished = true;
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("进来了");
        if (newQuest.isFinished==false)
        {
            CompeleteQuest();
            questManager.GetComponent<SmallScene_Quest_QuestableNPCs_QuestSystem>().questList.Add(newQuest);
            questManager.GetComponent<SmallScene_Quest_QuestableNPCs_QuestSystem>().UpdateClues();
            dialog.SetActive(true);
            Debug.Log("添加完毕");

        }
    }
}
