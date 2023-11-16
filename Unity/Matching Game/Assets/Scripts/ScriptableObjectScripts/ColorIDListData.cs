using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIDListData : ScriptableObject
{
    public List<ColorID> ColorIDList;
    public ColorID currentColor;
    private int num;

    public void setCurrentColorRandomly()
    {
        num = Random.Range(0, ColorIDList.Count);
        currentColor = ColorIDList[num];
    }
}
