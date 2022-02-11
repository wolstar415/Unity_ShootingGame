using UnityEngine;
using WindowsInput;

public class PlayerMove : MonoBehaviour
{

    public float movefloat;
    public float limitfloat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || WinInput.GetKey(KeyCode.A))
        {
            transform.Translate(-movefloat * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || WinInput.GetKey(KeyCode.D))
        {
            transform.Translate(movefloat * Time.deltaTime, 0, 0);

        }

        if (transform.position.x >= limitfloat)
        {
            transform.position = new Vector3(limitfloat, transform.position.y, transform.position.z);

        }

        if (transform.position.x <= -limitfloat)
        {
            transform.position = new Vector3(-limitfloat, transform.position.y, transform.position.z);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           UnityEngine.SceneManagement.SceneManager.LoadScene(0);

        }
        // print(Time.deltaTime);




    }
}
