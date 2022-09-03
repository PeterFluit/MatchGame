using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }
}
