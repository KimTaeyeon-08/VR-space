using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipmovement : MonoBehaviour
{
    public GameObject Head;
    public GameObject Cam;
    public GameObject SpaceShip;

    float CurrRot;//current rotation 
    float PrevRot;//previous rotation
    float DeltRot;//current - previous
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(Cam.transform.forward* Time.deltaTime*4f);
        tilt();    
    }
    void tilt()
    {
        CurrRot = Cam.transform.eulerAngles.y;//current rotation is camera's y rotaion
        DeltRot = CurrRot - PrevRot;//ex)PrevRot = 0
        PrevRot = CurrRot;

        if (DeltRot > 0) {
            //turn right
            SpaceShip.transform.localRotation =
  Quaternion.Lerp(SpaceShip.transform.localRotation,
  Quaternion.Euler(SpaceShip.transform.localRotation.x,
  SpaceShip.transform.localRotation.y, -45), Time.deltaTime);
        }
       else if (DeltRot < 0)
        {//turn left 
            SpaceShip.transform.localRotation =
  Quaternion.Lerp(SpaceShip.transform.localRotation,
  Quaternion.Euler(SpaceShip.transform.localRotation.x,
  SpaceShip.transform.localRotation.y, 45), Time.deltaTime);
        }
        else //if (DeltRot == 0)
        {//initial spaceship 
            SpaceShip.transform.localRotation =
  Quaternion.Lerp(SpaceShip.transform.localRotation,
  Quaternion.Euler(SpaceShip.transform.localRotation.x,
  SpaceShip.transform.localRotation.y, 0), Time.deltaTime);
        }



    }
}
