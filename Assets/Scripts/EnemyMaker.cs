using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    public GameObject Enemy;
    public float createtime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeEnemy", 0, createtime);

    }

    void MakeEnemy()
    {
        GameObject a = Instantiate(Enemy, transform.position, transform.rotation);
        Destroy(a, 3);

    }
}
