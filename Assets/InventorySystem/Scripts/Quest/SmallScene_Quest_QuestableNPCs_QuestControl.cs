using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_Quest_QuestableNPCs_QuestControl : MonoBehaviour
{
    [SerializeField]
    public Quest newQuest;
    public GameObject questManager;
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
        Debug.Log("������");
        if (newQuest.isFinished!=true)
        {
            CompeleteQuest();
            questManager.GetComponent<SmallScene_Quest_QuestableNPCs_QuestSystem>().questList.Add(newQuest);
            Debug.Log("������");

        }
    }
}
