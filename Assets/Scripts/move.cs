using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject plane;
    float pos1;
    float pos2;
    public GameObject section;
    float z;
    float x;
    int count;
    bool normal;
    public Camera cam;
    Vector3 grav;
    // Start is called before the first frame update
    void Start()
    {
        //count = 0;
        //pos1 = 0;
        //for(int i = 0; i < 25; i++)
        //{
        //    //rand = (int)Random.Range(3, 7);
        //    for (int j = 0; j < 7; j++)
        //    {
        //        if (Random.Range(0, 10) <= 5)
        //        {
        //            z = 10 * i + 70;
        //            x = -30 + 10 * j;
        //            Instantiate(section, new Vector3(x, 0, z), Quaternion.identity);
        //        }
        //    }
        //}
        normal = true;
        grav = Physics.gravity;
    }

    // Update is called once per frame
    void Update()
    {
        //pos2 = transform.position.z - pos1;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            normal = !normal;
            if (normal)
                Physics.gravity = grav;
            else
                Physics.gravity = -grav;
        }
        transform.Translate(0, 0, 0.03f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(normal)
                transform.GetComponent<Rigidbody>().AddForce(Vector3.right * 5f);
            else
                transform.GetComponent<Rigidbody>().AddForce(Vector3.left * 5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(normal)
                transform.GetComponent<Rigidbody>().AddForce(Vector3.left * 5f);
            else
                transform.GetComponent<Rigidbody>().AddForce(Vector3.right * 5f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && (transform.position.y <= 1 || transform.position.y >= 39))
        {
            if (normal)
            {
                transform.GetComponent<Rigidbody>().AddForce(Vector3.up * 30f, ForceMode.Impulse);
            }
            else
            {
                transform.GetComponent<Rigidbody>().AddForce(Vector3.down * 30f, ForceMode.Impulse);
            }
        }

        if (transform.position.y < -3)
            transform.position = new Vector3(0, 1, 0);
        if (transform.position.y > 43)
            transform.position = new Vector3(0, 39, 0);


        //if (pos2 > 9.9)
        //{
        //    count++;
        //    z = 310 + count * 10;
        //    pos1 = count * 10;
        //    for(int j = 0; j < 7; j++)
        //    {
        //        if (Random.Range(0, 10) <= 6)
        //        {
        //            x = -30 + 10 * j;
        //            Instantiate(section, new Vector3(x, 0, z), Quaternion.identity);
        //        }
        //    }
        //}
    }
}