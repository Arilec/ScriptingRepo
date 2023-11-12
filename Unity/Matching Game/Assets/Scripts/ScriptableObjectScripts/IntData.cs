using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Int Data",menuName = "Int Data")]
public class IntData : ScriptableObject
{
    
    public int value; 
    
    public UnityEvent comparison;

    public void compare(IntData obj)
    {
        if (obj.value > value)
        {
            value = obj.value;
        }
    }

    public void SetValue(int num)
    {
        value = num;
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }
    public void updateValue(int num)
    {
        value += num;
    }

}