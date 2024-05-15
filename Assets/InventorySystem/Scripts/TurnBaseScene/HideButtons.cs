using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButtons : MonoBehaviour
{
    public List<GameObject> childs = new List<GameObject>();
    public void OnClick()
    {

            foreach (var child in childs)
            {
                child.SetActive(false);
            }

    }
}
