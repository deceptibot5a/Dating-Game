using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Fungus;

public class DiaManager : MonoBehaviour
{
    public Flowchart fuegoDia1Flowchart;
    public Flowchart fuegoDia2Flowchart;

    private int numeroDelDia = 1; // Valor inicial del número de día

    // Método para cambiar el número del día
    public void CambiarNumeroDelDia(int nuevoNumero)
    {
        numeroDelDia = nuevoNumero;
    }

    // Método para iniciar la conversación según el día
    public void IniciarConversacion()
    {
        Debug.Log("Iniciando conversación para el día: " + numeroDelDia);
        switch (numeroDelDia)
        {
            case 1:
                Debug.Log("Ejecutando FuegoDia1");
                IniciarConversacion(fuegoDia1Flowchart, "FuegoDia1");
                break;

            case 2:
                Debug.Log("Ejecutando FuegoDia2");
                IniciarConversacion(fuegoDia2Flowchart, "FuegoDia2");
                break;

            // Agrega más casos según sea necesario

            default:
                Debug.LogWarning("Número del día no reconocido: " + numeroDelDia);
                break;
        }
    }

    private void IniciarConversacion(Flowchart flowchart, string nombreDelBloque)
    {
        // Asegurarse de que el flowchart no sea nulo
        if (flowchart != null)
        {
            // Ejecutar el bloque específico dentro del flowchart
            flowchart.ExecuteBlock(nombreDelBloque);
        }
        else
        {
            Debug.LogError("Flowchart no asignado para el día actual.");
        }
    }
}