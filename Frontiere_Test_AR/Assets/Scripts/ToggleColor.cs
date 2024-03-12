using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleColor : MonoBehaviour
{
    private Toggle toggle;
    // Start is called before the first frame update
    private void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool isOn)
    {

        ColorBlock cb = toggle.colors;
        if (isOn)
        {
            cb.normalColor = Color.cyan;
            cb.highlightedColor = Color.cyan;
            cb.selectedColor = Color.cyan;
        }
        else
        {
            cb.normalColor = Color.white;
            cb.highlightedColor = Color.white;
            cb.selectedColor = Color.white;
        }
        
        toggle.colors = cb;
    }
}
