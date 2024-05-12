using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScene_BackGround_BackGround_Parallax : MonoBehaviour
{
    public Transform target;
    public Transform farBackGround, midBackGround,nearBackGround;
    public float farSpeed, midSpeed, nearSpeed;
    private Vector2 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y+2.2f, transform.position.z);
        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);
        farBackGround.position += new Vector3(amountToMove.x*farSpeed, amountToMove.y*farSpeed, 0f);
        midBackGround.position += new Vector3(amountToMove.x * midSpeed, amountToMove.y * midSpeed, 0f);
        nearBackGround.position += new Vector3(amountToMove.x * nearSpeed, amountToMove.y * nearSpeed, 0f);
        lastPos = transform.position;

    }
}
