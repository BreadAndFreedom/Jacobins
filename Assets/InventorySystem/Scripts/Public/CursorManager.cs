using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursor;

    private static CursorManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            instance.ChangeCursor();
        }
    }


    public void ChangeCursor()
    {
        // �����µ����ָ��ͼ��
        Cursor.SetCursor(cursor,new Vector2 (cursor.width / 2, cursor.height / 2), CursorMode.Auto);
    }
}