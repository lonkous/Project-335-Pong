using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    float x;



    float x1;
    float x2;
    float x3;
    float x4;
    public PlayerMovement player;
    public GameObject Background1;
    public GameObject Background2;
    public GameObject Background3;
    public GameObject Background4;
    public GameObject Background5;

    void Update()
    {
        if (x < player.CurrentX())
        {
            x += 0.02f;
        }
        //if x is greater than currentX add force to the left
        if (x > player.CurrentX())
        {
            x -= 0.02f;
        }
        if (x1 < player.CurrentX())
        {
            x1 += 0.009f;
        }
        //if x is greater than currentX add force to the left
        if (x1 > player.CurrentX())
        {
            x1 -= 0.009f;
        }
        if (x2 < player.CurrentX())
        {
            x2 += 0.005f;
        }
        //if x is greater than currentX add force to the left
        if (x2 > player.CurrentX())
        {
            x2 -= 0.005f;
        }
        if (x3 < player.CurrentX())
        {
            x3 += 0.002f;
        }
        //if x is greater than currentX add force to the left
        if (x3 > player.CurrentX())
        {
            x3 -= 0.002f;
        }
        if (x4 < player.CurrentX())
        {
            x4 += 0.001f;
        }
        //if x is greater than currentX add force to the left
        if (x4 > player.CurrentX())
        {
            x4 -= 0.001f;
        }


        // move game object to the right
        Background1.transform.position = new Vector3(x, Background1.transform.position.y, Background1.transform.position.z);
        Background2.transform.position = new Vector3(x1, Background2.transform.position.y, Background2.transform.position.z);
        Background3.transform.position = new Vector3(x2, Background3.transform.position.y, Background3.transform.position.z);
        Background4.transform.position = new Vector3(x3, Background4.transform.position.y, Background4.transform.position.z);
        Background5.transform.position = new Vector3(x4, Background5.transform.position.y, Background5.transform.position.z);


    }
}