using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodePanelControl : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetBool("IsMoving", true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.SetBool("IsMoving", false);
        }
    }
}
