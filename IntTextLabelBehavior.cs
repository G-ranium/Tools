using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class IntTextLabelBehavior : MonoBehaviour
{
    public Text label;
    public IntData dataObj;
    public String labelName;

    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = labelName + " " + dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
    
}