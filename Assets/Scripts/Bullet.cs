using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletspeed;
    public float limitY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletspeed * Time.deltaTime, 0);

        if (transform.position.y > limitY)
        {
            Destroy(gameObject);
            //print("ÆÄ±«");

        }
    }
}
