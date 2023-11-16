using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Flowchart flowchart;
    public string nombreVariable;
    public Slider miSlider;
    object valorVariable;

    void Update() {
        valorVariable = flowchart.GetVariable(nombreVariable).GetValue();
        miSlider.value = Convert.ToSingle(valorVariable)*0.01f;
    }
}
