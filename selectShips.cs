using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectShips : MonoBehaviour
{
    public void sparrow1()
    {
        PlayerPrefs.SetInt("ShipType", 1);
        SceneManager.LoadScene("GameplayScene");
    }
    public void sparrow2()
    {
        PlayerPrefs.SetInt("ShipType", 2);
        SceneManager.LoadScene("GameplayScene");
    }
}
