using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_Npc_All_HighLight : MonoBehaviour
{
    public GameObject dialogBlock;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnTriggerStay(Collider other)
    //{
    //    dialogBlock.SetActive(true);
    //    Debug.Log("Enter");
    //}

    private void OnTriggerEnter(Collider other)
    {
        dialogBlock.SetActive(true);
        Debug.Log("Enter");
    }
    private void OnTriggerExit(Collider other)
    {
        dialogBlock.SetActive(false);
        Debug.Log("Leave");
    }
}
