using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseScene_Player_MainCharacter_HealthBar : MonoBehaviour
{
    public float health=100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetDamanged()
    {
        health = health - 50f;
        Debug.Log(health);
    }
}
