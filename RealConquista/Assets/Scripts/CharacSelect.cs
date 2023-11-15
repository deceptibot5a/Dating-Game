using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CharacSelect : MonoBehaviour
{
    public void LoadFireScene()
    {
        SceneManager.LoadScene("InteractFuego");
    }

    public void LoadWaterScene()
    {
        SceneManager.LoadScene("InteractAgua");
    }

    public void LoadLightScene()
    {
        SceneManager.LoadScene("InteractLuz");
    }

    public void LoadDarkScene()
    {
        SceneManager.LoadScene("InteractOscuro");
    }

    public void LoadMechaScene()
    {
        SceneManager.LoadScene("InteractMecanica");
    }

}
