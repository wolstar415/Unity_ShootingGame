using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firemanager : MonoBehaviour

    
{

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }
}
