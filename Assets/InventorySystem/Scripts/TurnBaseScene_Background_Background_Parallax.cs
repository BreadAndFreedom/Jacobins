using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseScene_Background_Background_Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform farBackground, midBackground,nearBackground,Character;
    public float farSpeed;
    public float midSpeed;
    public float nearSpeed;
    private Vector2 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);
        Character.position += new Vector3(amountToMove.x * 1f, amountToMove.y * 1f, 0f);
        farBackground.position += new Vector3(amountToMove.x * farSpeed, amountToMove.y * farSpeed, 0f);
        midBackground.position += new Vector3(amountToMove.x * midSpeed, amountToMove.y * midSpeed, 0f);
        nearBackground.position += new Vector3(amountToMove.x * nearSpeed, amountToMove.y * nearSpeed, 0f);
        lastPos = transform.position;

    }
}
