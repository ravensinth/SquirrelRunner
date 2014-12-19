using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowSliderValue : MonoBehaviour {
    public Slider ThisSlider;
    public Text ThisText;

    public void UpdateTextWithValue() {
        ThisText.text = ThisSlider.value.ToString();    
    }
}
