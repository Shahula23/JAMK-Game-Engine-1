using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTools : MonoBehaviour
{
 
    public void ActivatePanel(GameObject panel)
    {
        panel.SetActive(true);
    }


    public void DeactivatePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void closeApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
