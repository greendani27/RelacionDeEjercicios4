using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    [SerializeField] bool gameStarted;
    private float timeElapsed;
    private int minutes, seconds, cents;
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
            timeElapsed += Time.deltaTime;
            minutes = (int)(timeElapsed / 60f);
            seconds = (int)(timeElapsed - minutes * 60f);
            cents = (int)((timeElapsed - (int)timeElapsed) * 100f);
            GameObject.FindGameObjectWithTag("timer").GetComponent<Text>().text = string.Format("{0}:{1}:{2}", minutes, seconds, cents);
        }
    }
    public void DestroyGameobject(GameObject bullet, GameObject enemy)
    {
        Destroy(bullet);
        Destroy(enemy);
    }
}
