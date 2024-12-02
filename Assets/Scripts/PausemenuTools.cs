using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausemenuTools : MonoBehaviour
{
    public bool isPaused;
    public GameObject pausePanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }


    public void Pause()
    {
        isPaused = true;
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void CursorFree()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
