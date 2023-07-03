using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiChuyenBong : MonoBehaviour
{
    public float speed=0;
    public float x=0, y=0, z=0;
    public float bandau = 0;
    private bool ktlan = true, dau=true;
    private float t = 10;
    private void FixedUpdate()
    {
        float horAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        if (bandau == 5 * 144)
        {
            ktlan = false;
            dau = false;
        }    
           
        if (bandau == 0)
            ktlan = true;
        
        if (bandau < 5 * 144 && ktlan == true)
        {
            bandau += 1;
            if (dau)
                t = 10;
            else
                t = 20;
            z = t;
        }

        if (bandau > 0 && ktlan == false)
        { 
            bandau -= 1;
            z = -20;
        }    
        
        Vector3 movement = new Vector3(x, y, z);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}
