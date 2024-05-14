using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    public GameObject activeImage, defaultImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        defaultImage.SetActive(false);
        activeImage.SetActive(true);
    }
    private void OnMouseExit()
    {
        defaultImage.SetActive(true);
        activeImage.SetActive(false);
    }
}
