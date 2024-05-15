using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBaseScene_Player_MainCharacter_HealthBar : MonoBehaviour
{
    public float health=100f;
    public GameObject winDialog, loseDialog;

    public void DealDamange()
    {
        health += 50;
        if (health <= 0)
        {
            loseDialog.SetActive(true);
        }
        if (health >= 200)
        {
            GameObject.Find("RightHand").GetComponent<Button>().interactable = true;
            GameObject.Find("CheckMateUI").GetComponent<Animator>().SetBool("IsActive", true);
        }
    }
    public void GetDamanged()
    {
        health -= 50;
        if (health <= 0)
        {
            loseDialog.SetActive(true);
        }
        if (health >= 200)
        {
            GameObject.Find("RightHand").GetComponent<Button>().interactable = true;
            GameObject.Find("CheckMateUI").GetComponent<Animator>().SetBool("IsActive", true);
        }
    }
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            DealDamange();
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            GetDamanged();
        }
    }
}
