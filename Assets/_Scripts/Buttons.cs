using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public StartLevel StartLevel;
    public void Start_Level()
    {
        StartLevel.MenuGone();
    }

    public GameObject creditsmenu;
    public GameObject instructionsmenu;

    public static void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1.0f;

    }
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1.0f;

    }
    public static void LoadWinScreen()
    {
        SceneManager.LoadScene("End_Screne");
        Time.timeScale = 1.0f;

    }
    public static void LoadLossScreen()
    {
        SceneManager.LoadScene("Loss_Screne");
        Time.timeScale = 1.0f;
    }
    public static void Quitbutton()
    {
        Application.Quit();

    }
    public void Instructions()
    {
        instructionsmenu.SetActive(true);

    }
    public void credits()
    {
        creditsmenu.SetActive(true);

    }











}
