using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameObject Player;
    public GameObject Menu;
    public GameObject StartMaze;

    public void MenuGone()
    {
        Player.SetActive(true);
        StartMaze.SetActive(true);
        Menu.SetActive(false);
        Time.timeScale = 1.0f;

    }

    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(false);
        StartMaze.SetActive(false);
        Menu.SetActive(true);
        Time.timeScale = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
