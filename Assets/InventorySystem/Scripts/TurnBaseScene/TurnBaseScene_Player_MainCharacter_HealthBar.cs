using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseScene_Player_MainCharacter_HealthBar : MonoBehaviour
{
    public float health=100f;

    public void DealDamange(float damange)
    {
        health += damange;
    }
}
