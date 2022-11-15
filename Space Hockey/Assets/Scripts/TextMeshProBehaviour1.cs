using System;
using System.ComponentModel;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class TextMeshProBehaviour1 : MonoBehaviour

{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;
    public GameAction gameActionObj;

    private void Start()
    {
        gameActionObj.raiseNoArgs += Raise;
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    private void Raise()
    {
        raiseEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateText(IntData intDataObj)
    {
        label.text = intDataObj.value.ToString();
    }
}


//4:45 in video