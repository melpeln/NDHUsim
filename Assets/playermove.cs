using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public Rigidbody rs;
    public float verticalforce = 300f;
    public float diagonalforce = 300f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            rs.AddForce(verticalforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rs.AddForce(-verticalforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rs.AddForce(0, 0, diagonalforce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rs.AddForce(0, 0, -diagonalforce * Time.deltaTime);
        }
        //rs.AddForce(forwardforce * Time.deltaTime, 0, 0);

    }

}
