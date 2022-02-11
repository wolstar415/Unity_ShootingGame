using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour
{
    public GameObject Enemy;
    public float curTime;
    public float coolTime;


    void Update()
    {
        curTime += Time.deltaTime;
        if(curTime > coolTime)
        {
            curTime = 0;
            // print("here!!!!!");
            MakeEnemy();
        }
    }

    void MakeEnemy()
    {
        
        
        GameObject a = Instantiate(Enemy, transform.position, transform.rotation);
        //Destroy(a, 3);

    }
}
