using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Texture2D cursor;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, hotSpot, cursorMode);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, hotSpot, cursorMode);
    }
}
