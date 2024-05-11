using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseScene_UI_CastBar_Shift : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=gameObject.GetComponent<Animator>();
    }

    private void OnMouseExit()
    {
        animator.SetBool("IsMouseInside",false);
    }
    private void OnMouseEnter()
    {
        animator.SetBool("IsMouseInside", true);
    }
}
