using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectCollision : MonoBehaviour
{
    gameController controller = new gameController();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Text counter = GameObject.FindGameObjectWithTag("counter").GetComponent<Text>();
        counter.text = (int.Parse(counter.text) + 1).ToString();
        controller.DestroyGameobject(gameObject, collision.gameObject);
    }
}
