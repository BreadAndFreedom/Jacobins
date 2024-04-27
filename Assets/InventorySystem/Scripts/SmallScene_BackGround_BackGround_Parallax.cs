using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_BackGround_BackGround_Parallax : MonoBehaviour
{
    public Transform target;
    public Transform farBackGround, midBackGround;
    private Vector2 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y+3f, transform.position.z);
        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);
        farBackGround.position += new Vector3(amountToMove.x*0.8f, amountToMove.y*0.8f, 0f);
        midBackGround.position += new Vector3(amountToMove.x * 0.5f, amountToMove.y * 0.5f, 0f);
        lastPos = transform.position;

    }
}
