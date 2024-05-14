using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarMoving : MonoBehaviour
{
    public TurnBaseScene_Player_MainCharacter_HealthBar healthManager;
    public float lastHealth;
    public float speed;
    // Start is called before the first frame update
    public void Awake()
    {
        lastHealth = healthManager.health;
    }

    // Update is called once per frame
    void Update()
    {
        float changeHealth =  lastHealth- healthManager.health;
        gameObject.transform.Translate(changeHealth / speed,0,0);
        lastHealth = healthManager.health;

    }

}
