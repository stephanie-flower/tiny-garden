using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGrowth : MonoBehaviour
{
    public Sprite[] states;
    private int currentState;

    public float growthRate;
    private float nextChange;

    private SpriteRenderer spriteRenderer;
    private int timeCounter;

    void ChangeState()
    {
        if (currentState < states.Length - 1 && this.transform.parent.GetComponent<changeOnClick>().wateredState)
        {
            currentState += 1;
            spriteRenderer.sprite = states[currentState];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentState = 0;
        timeCounter = 0;
        nextChange = growthRate;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timeCounter == nextChange)
        {
            ChangeState();
            nextChange += growthRate;
        }
        timeCounter++;
    }
}
