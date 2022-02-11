using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float deadtime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deadtime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
