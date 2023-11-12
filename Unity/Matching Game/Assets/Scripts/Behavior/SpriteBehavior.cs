using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererOBJ;
    // Start is called before the first frame update
    void Awake()
    {
        rendererOBJ = GetComponent<SpriteRenderer>(); //assign spriteRenderer
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererOBJ.color = obj.value; //gets color and shifts
    }

  
}
