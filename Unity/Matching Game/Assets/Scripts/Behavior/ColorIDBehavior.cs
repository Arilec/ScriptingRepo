using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDListData colorDataList;

    private void Awake()
    {
        IDObj = colorDataList.currentColor;
    }
}
