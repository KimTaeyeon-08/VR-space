using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//handle the Scene

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameplayScene");
    }
    public void goToSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
