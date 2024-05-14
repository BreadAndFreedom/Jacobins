using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private float horizontal;
    private float vertical;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        gameObject.transform.Translate(speed * Time.deltaTime * horizontal, speed*Time.deltaTime*vertical, 0);
    }
}
