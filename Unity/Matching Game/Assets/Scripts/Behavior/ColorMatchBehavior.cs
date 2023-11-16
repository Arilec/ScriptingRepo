using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorIDListData colorDataList;

    private void Awake()
    {
        IDObj = colorDataList.currentColor;
    }

    public void changeColor(SpriteRenderer renderer)
    {
        var newColor = IDObj as ColorID;
        renderer.color = newColor.value;
    }
}
