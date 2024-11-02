using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingMenu;
    public GameObject creditMenu;

    public void play()
    {
        //SceneManager.LoadScene(1);
        print("Play");
    }

    public void setting()
    {
        mainMenu.SetActive(false);
        settingMenu.SetActive(true);
        print("Setting");
    }

    public void credit()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
        print("Credit");
    }

    public void back()
    {
        mainMenu.SetActive(true);
        settingMenu.SetActive(false);
        creditMenu.SetActive(false);
        print("Back");
    }

    public void quit()
    {
        Application.Quit();
        print("Quit");
    }
}
