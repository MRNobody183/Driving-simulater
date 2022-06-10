using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    public GameObject Panel;
   

    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void SettingPanel()
    {
        Panel.SetActive(true);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        Panel.SetActive(false);
    }
}
