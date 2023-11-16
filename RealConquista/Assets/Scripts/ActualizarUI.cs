using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;

public class ActualizarUI : MonoBehaviour
{
    public TextMeshProUGUI textoDiaGlobal;
    
    public Flowchart flowchart;

    void Update()
    {
        if (flowchart != null)
        {
            int valorDiaGlobal = flowchart.GetIntegerVariable("diaGlobal");

            textoDiaGlobal.text = "Día global: " + valorDiaGlobal.ToString();

        }
        else
        {
            Debug.LogError("El Flowchart no se ha asignado en el Inspector de Unity.");
        }
    }
}