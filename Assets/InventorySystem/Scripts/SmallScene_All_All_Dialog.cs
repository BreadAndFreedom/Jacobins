using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SmallScene_All_All_Dialog : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("文本")]
    public TextAsset textFile;
    [Header("UI")]
    public Text textLabel;

    List<string> textList = new List<string>();
    public int index;
    void Start()
    {
        GetTextFromFile(textFile);
        textLabel.text = textList[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetTextFromFile(TextAsset textFile)
    {
        textList.Clear();
        var lineData=textFile.text.Split('\n');

        foreach(var line in lineData)
        {
            textList.Add(line);
        }
    }
    public void GetNextText()
    {
        Debug.Log("骰子已经掷下");
        index++;
        textLabel.text = textList[index];
        
    }
}
