using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D shovelTexture;
    public Texture2D sproutTexture;
    public Texture2D wateringcanTexture;
    public Texture2D buildTexture;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public static ToolType currentTool;

    public enum ToolType
    {
        Cursor,
        Shovel,
        Sprout,
        WateringCan,
        Build
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ChangeToCursor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToCursor()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        currentTool = ToolType.Cursor;
    }

    public void ChangeToShovel()
    {
        Cursor.SetCursor(shovelTexture, hotSpot, cursorMode);
        currentTool = ToolType.Shovel;
    }

    public void ChangeToSprout()
    {
        Cursor.SetCursor(sproutTexture, hotSpot, cursorMode);
        currentTool = ToolType.Sprout;
    }

    public void ChangeToWateringCan()
    {
        Cursor.SetCursor(wateringcanTexture, hotSpot, cursorMode);
        currentTool = ToolType.WateringCan;
    }

    public void ChangeToBuild()
    {
        Cursor.SetCursor(buildTexture, hotSpot, cursorMode);
        currentTool = ToolType.Build;
    }
}
