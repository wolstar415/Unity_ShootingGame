using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Application.LoadLevel(1);

            SceneManager.LoadScene(1);


        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("Game Exit!!!!!!!!!!!");
            Application.Quit();
        }
    }
}
