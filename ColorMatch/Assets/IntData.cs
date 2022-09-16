using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int number)
    {
        value += number;
    }
}