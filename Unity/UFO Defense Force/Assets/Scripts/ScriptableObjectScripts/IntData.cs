using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Int Data",menuName = "Int Data")]
public class IntData : ScriptableObject
{
    [SerializeField] private int value;

    public int Value
    {
        get{ return value; }
        set { this.value = value; }
    }
}
