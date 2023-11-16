using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class InteractionManager : MonoBehaviour
{
    public Flowchart flowchart;
    public string nombreVariable;
    object valorVariable;
    private bool isBloqued = false;
    public Button miBoton;
    float diaAnterior = 1;

    void Update() {
        valorVariable = flowchart.GetVariable(nombreVariable).GetValue();
        float valorDia = Convert.ToSingle(valorVariable);
        
        if (valorDia > diaAnterior) {
            if (diaAnterior != valorDia) {
                diaAnterior = valorDia;
                DiasGlobales.transcurso += 1;
            }
        }
        if ((valorDia >= 8 && isBloqued == false) || DiasGlobales.transcurso >= 15) BloquearInteraccion();
    }

    public void BloquearInteraccion() {
        isBloqued = true;
        miBoton.interactable = false;
    }
}
