using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class State
    {
        public Color fillColor;
        public Color outlineColor;
    }
    private TextMeshProUGUI _text;
    private Image fill;
    private Outline outline;
    public State state { get; private set; }
    public char letter { get; private set; }

    private void Awake()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
        fill = GetComponent<Image>();
        outline = GetComponent<Outline>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        _text.text = letter.ToString();
    }

    public void SetState(State state)
    {
        this.state = state;
        fill.color = state.fillColor;
        outline.effectColor = state.outlineColor;
    }
}
