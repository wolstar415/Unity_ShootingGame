using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public GameObject effect;
    public int hp;
    public ScoreManager scoreManager;

    public void Start()
    {
      scoreManager =  GameObject.Find("ScoreText").GetComponent<ScoreManager>();
    
    }


    public void OnTriggerEnter(Collider other)
    {
        //  print(other.gameObject.name +  " ::::  충돌함");
        //print("충돌");

        if (other.gameObject.tag =="Bullet")
        {
           // print("충돌");

            Destroy(other.gameObject);
            hp--;
           // print(hp);

            if (hp <= 0)
            {
                Destroy(gameObject);
                //
                //
                scoreManager.PlusScore();
                GameObject a = Instantiate(effect, transform.position, transform.rotation);
                Destroy(a, 1);

                //Destroy(other.gameObject);
            }

        }

    }

}
