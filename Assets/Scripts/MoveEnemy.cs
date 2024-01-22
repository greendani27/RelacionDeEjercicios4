using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);

        if (transform.position.x > 12) {
            Destroy(gameObject);
        }
    }
}
