using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeByCursor : MonoBehaviour {
    /*
    [SerializeField]
    Texture2D startcursor;

    [SerializeField]
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    */
    MaterialChanger changer;
    
    private void Start()
    {
        //Cursor.SetCursor(startcursor, Vector2.zero, cursorMode);
        changer = GetComponent<MaterialChanger>();
    }
    
    void OnMouseEnter()
    {
        //Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
        changer.HighLightObject();
    }

    

    void OnMouseExit()
    {
        //Cursor.SetCursor(startcursor, Vector2.zero, cursorMode);
        changer.BackMaterials();
    }
}

