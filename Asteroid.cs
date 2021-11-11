using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject ExpObj;
    private void OnTriggerEnter(Collider other)
    {
        ExpObj.SetActive(true);
        transform.GetComponent<MeshRenderer>().enabled = false;//turn off the mesh renderer (trick)
        Invoke("DestObj", 2);//find DestObj after 2second 
        
    }
    void DestObj()
    {
        Destroy(this.gameObject);
    }
}
