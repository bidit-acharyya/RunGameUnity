using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < ball.transform.position.z - 10 && transform.position.z > 0)
        {
            Destroy(transform.gameObject);
        }
    }
}
