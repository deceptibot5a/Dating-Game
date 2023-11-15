using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Fungus;

public class DiaManager : MonoBehaviour
{
    public Flowchart fuegoDia1Flowchart;
    public Flowchart fuegoDia2Flowchart;

    private int numeroDelDia = 1; // Valor inicial del n�mero de d�a

    // M�todo para cambiar el n�mero del d�a
    public void CambiarNumeroDelDia(int nuevoNumero)
    {
        numeroDelDia = nuevoNumero;
    }

    // M�todo para iniciar la conversaci�n seg�n el d�a
    public void IniciarConversacion()
    {
        Debug.Log("Iniciando conversaci�n para el d�a: " + numeroDelDia);
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

            // Agrega m�s casos seg�n sea necesario

            default:
                Debug.LogWarning("N�mero del d�a no reconocido: " + numeroDelDia);
                break;
        }
    }

    private void IniciarConversacion(Flowchart flowchart, string nombreDelBloque)
    {
        // Asegurarse de que el flowchart no sea nulo
        if (flowchart != null)
        {
            // Ejecutar el bloque espec�fico dentro del flowchart
            flowchart.ExecuteBlock(nombreDelBloque);
        }
        else
        {
            Debug.LogError("Flowchart no asignado para el d�a actual.");
        }
    }
}