using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPlots : MonoBehaviour
{

    public int rows;
    public int cols;
    public float offset;

    public Vector2 inPos;
    private GameObject tile;
    private SpriteRenderer spriteRenderer;

    void generateGrid()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                var tileInstance = GameObject.Instantiate(tile, new Vector2(inPos.x + j*offset, inPos.y + i*offset), transform.rotation);
                tileInstance.transform.parent = gameObject.transform;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        tile = Resources.Load("plots/plot") as GameObject;
        generateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
