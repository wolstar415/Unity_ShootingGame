using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRolling : MonoBehaviour
{
    public Vector3 originPos;
    public float speed;
    public float limitY;
    // Start is called before the first frame update
    void Start()
    {
        //originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);

        if (transform.position.y < -limitY)
        {
            transform.position = originPos;

        }
    }
}
