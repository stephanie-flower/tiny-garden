using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class changeOnClick : MonoBehaviour
{
    public Sprite tile;
    public Sprite tilled_tile;
    public Sprite tilled_watered_tile;
    public Sprite watered_tile;

    private SpriteRenderer spriteRenderer;

    public bool tilledState;
    public bool wateredState;
    public bool planted;
    private GameObject plant;

    // Start is called before the first frame update
    void Start()
    {
        //Tool.currentTool;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        plant = Resources.Load("plots/plants/plant") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void waterTile()
    {
        if (!wateredState)
        {
            wateredState = true;
            if (tilledState)
            {
                spriteRenderer.sprite = tilled_watered_tile;
            }
            else
            {
                spriteRenderer.sprite = watered_tile;
            }
        }
    }

    void tillTile()
    {
        if (!tilledState)
        {
            tilledState = true;
            if (wateredState)
            {
                spriteRenderer.sprite = tilled_watered_tile;
            } 
            else
            {
                spriteRenderer.sprite = tilled_tile;
            }
        }
    }

    void plantSprout()
    {
        if(tilledState)
        {
            if (!planted)
            {
                var plantInstance = GameObject.Instantiate(plant, transform.position, transform.rotation);
                plantInstance.transform.parent = gameObject.transform;
                planted = true;
            }
        }

    }

    void OnMouseDown()
    {
        Debug.Log("square clicked");
        switch (Tool.currentTool)
        {
            case Tool.ToolType.Shovel:
                tillTile();
                break;
            case Tool.ToolType.WateringCan:
                waterTile();
                break;
            case Tool.ToolType.Sprout:
                plantSprout();
                break;
            default:
                Debug.Log("Cursor tool undefined");
                break;
        }
    }
}
