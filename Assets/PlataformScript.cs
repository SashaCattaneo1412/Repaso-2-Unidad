using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformScript : MonoBehaviour
{
    public float xMovementSpeed;
    public float xRightLimit;
    public bool toRight;
    public float xleftlimit;
    public GameObject Cilindro;
    public GameObject Esfera;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (toRight == true )
        {
            transform.position += new Vector3(xMovementSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xMovementSpeed, 0, 0);
        }
        if (transform.position.x > xRightLimit)
        {
            toRight = false;
            Instantiate(Cilindro);

        }
        if(transform.position.x < xleftlimit)
        {
            toRight = true;
            Instantiate(Esfera);
        }

        

    }
}
