using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Collections.Specialized.BitVector32;

public class generateAbove : MonoBehaviour
{
    public GameObject section;
    public GameObject obstacle;
    float x, z, pos1, pos2;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        pos1 = 0;
        for (int i = 0; i < 12; i++)
        {
            //rand = (int)Random.Range(3, 7);
            for (int j = 0; j < 5; j++)
            {
                if (Random.Range(0, 10) <= 5)
                {
                    z = 20 * i + 80;
                    x = -40 + 20 * j;
                    Instantiate(section, new Vector3(x, 40, z), Quaternion.Euler(180,0,0));
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        pos2 = transform.position.z - pos1;
        if (pos2 > 9.9)
        {
            count++;
            z = 300 + count * 20;
            pos1 = count * 20;
            for (int j = 0; j < 5; j++)
            {
                if (Random.Range(0, 10) <= 6)
                {
                    x = -40 + 20 * j;
                    if (count % 5 == 0)
                    {
                        if (Random.Range(0, 10) <= 3)
                        {
                            Instantiate(obstacle, new Vector3(x, 36, z), Quaternion.Euler(180, 0, 0));
                        }
                    }
                    Instantiate(section, new Vector3(x, 40, z), Quaternion.Euler(180, 0, 0));
                }
            }
        }

        if (transform.position.y < -2.5 || transform.position.y > 42.5)
        {
            pos1 = 0;
            count = 0;
            for (int i = 0; i < 12; i++)
            {
                //rand = (int)Random.Range(3, 7);
                for (int j = 0; j < 5; j++)
                {
                    if (Random.Range(0, 10) <= 5)
                    {
                        z = 20 * i + 80;
                        x = -40 + 20 * j;
                        Instantiate(section, new Vector3(x, 40, z), Quaternion.Euler(180, 0, 0));
                    }
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Cube(Clone)")
        {
            if(transform.position.y < 20)
                transform.position = new Vector3(0, 1, 0);
            else
                transform.position = new Vector3(0, 39, 0);
            pos1 = 0;
            count = 0;
            for (int i = 0; i < 12; i++)
            {
                //rand = (int)Random.Range(3, 7);
                for (int j = 0; j < 5; j++)
                {
                    if (Random.Range(0, 10) <= 5)
                    {
                        z = 20 * i + 80;
                        x = -40 + 20 * j;
                        Instantiate(section, new Vector3(x, 40, z), Quaternion.Euler(180, 0, 0));
                    }
                }
            }
        }
    }
}
