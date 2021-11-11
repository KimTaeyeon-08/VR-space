using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectedShip : MonoBehaviour
{
    public GameObject ship01;//starsparrow 1
    public GameObject ship02;//starsparrow 2 

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("ShipType") == 1)
        {
            ship01.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("ShipType") == 2)
        {
            ship02.SetActive(true);
        }
    }

 
}
