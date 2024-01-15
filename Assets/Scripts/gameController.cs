using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [SerializeField] GameObject[] startHud;
    [SerializeField] GameObject[] gameplayHud;
    [SerializeField] GameObject player
        ;
    bool gameStarted = false;
    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Return))
        {
            for (int i = 0; i < startHud.Length; i++) {
                startHud[i].SetActive(false);
            }
            for (int i = 0; i < gameplayHud.Length; i++)
            {
                gameplayHud[i].SetActive(true);
            }
            player.SetActive(true);
            gameStarted = true;
        }
        else if (gameStarted && Input.GetKeyDown(KeyCode.Escape)) {
            for (int i = 0; i < startHud.Length; i++)
            {
                startHud[i].SetActive(true);
            }
            for (int i = 0; i < gameplayHud.Length; i++)
            {
                gameplayHud[i].SetActive(false);
            }
            player.SetActive(false);
            gameStarted = false;
        }
    }
}
