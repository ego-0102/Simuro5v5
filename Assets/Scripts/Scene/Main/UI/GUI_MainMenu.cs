﻿using Simuro5v5;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI_MainMenu : MonoBehaviour
{
    public GameObject aboutPage;

	void Start()
    {
        Screen.fullScreen = false;
        Configuration.ReadFromFileOrCreate("config.json");
        aboutPage.SetActive(false);
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(1))
        {
            aboutPage.SetActive(false);
        }
    }

    public void OnGameButtonClicked()
    {
        SceneManager.LoadScene("GameScene_Play");
    }

    public void OnAboutButtonClicked()
    {
        aboutPage.SetActive(true);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
