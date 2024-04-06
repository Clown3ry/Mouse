using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spritechange : MonoBehaviour
{
    public SpriteRenderer sp;
    public Sprite newSprite;
    public Sprite original Sprite;

    bool changed;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
{
        if (Input.GetMouseButtonDown(0))
        {
         ChangeSprite();
         changed = true;
        } 
    }

    If (Input.GetMouseButtonUp(0))
    {
        changeSprite()
        Changed = true;
    }
    void ChangeSprite()
    
        if()
}
