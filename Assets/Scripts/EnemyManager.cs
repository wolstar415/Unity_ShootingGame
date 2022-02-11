using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
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
            float x = Random.Range(-2.5f, 2.5f);
            float y = Random.Range(12, 18);
            transform.position=new Vector3(x, y, transform.position.z);
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
