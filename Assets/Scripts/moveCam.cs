using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    bool normal;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        normal = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            normal = !normal;
            if (normal)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y + 22, ball.transform.position.z-50);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 180);
                transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y - 22, ball.transform.position.z-50);
            }
        }
    }
}
