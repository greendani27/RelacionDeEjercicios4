using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    [SerializeField] bool gameStarted;
    Text timer;
    void Update()
    {
        changeScene();
    }

    void changeScene()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            SceneManager.LoadScene("Game");
            gameStarted = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && gameStarted)
        {
            SceneManager.LoadScene("SplashScreen");
            gameStarted = false;
        }
        if (SceneManager.GetActiveScene().name.Equals("Game"))
        {
            GameObject.FindGameObjectWithTag("timer").GetComponent<Text>().text = Time.time.ToString();

        }
    }
    public void DestroyGameobject(GameObject bullet, GameObject enemy)
    {
        Destroy(bullet);
        Destroy(enemy);
    }
}
