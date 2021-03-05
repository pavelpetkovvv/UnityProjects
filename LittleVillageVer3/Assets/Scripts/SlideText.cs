using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlideText : MonoBehaviour
{
    public string text;
    private TextMeshProUGUI TextPro;

    private void Start()
    {
        TextPro = GetComponent<TextMeshProUGUI>();
        changeText(text);
    }

    void changeText(string newText)
    {
        TextPro.text = newText;
    }
}
