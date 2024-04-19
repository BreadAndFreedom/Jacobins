using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_Protagonist_MainCharacter_Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float horizontal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(speed * Time.deltaTime*horizontal, 0, 0);
    }
}
