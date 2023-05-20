using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove : MonoBehaviour
{
    float timer;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(transform.position.z > 60)
        {
            if (transform.position.z < ball.transform.position.z - 30)
            {
                Destroy(transform.gameObject);
            }
            if (ball.transform.position.y < -2.5 || ball.transform.position.y > 42.5)
            {
                Destroy(transform.gameObject);
            }
        }
    }
}
