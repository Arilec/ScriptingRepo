using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    public int maxAmmo; 
    public int currentAmmo = 0;
    

    public void Reload(int value)
    {
        currentAmmo += value;
    }

    public void useAmmo(int value)
    {
        currentAmmo -= value;
        if (currentAmmo < 0)
            currentAmmo = 0;
    }
}
