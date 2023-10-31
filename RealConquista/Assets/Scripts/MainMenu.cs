using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject[] menuItems;
    public void PlayGame() {
        SceneManager.LoadScene(1);
    }
    public void BackToMain() {
        SceneManager.LoadScene(0);
    }
    public void ExitGame() {
        Application.Quit();
    }
    public void Credits() {
        menuItems[0].SetActive(false);
        menuItems[1].SetActive(true);
    }
    public void GoBack() {
        menuItems[1].SetActive(false);
        menuItems[0].SetActive(true);
    }
}
