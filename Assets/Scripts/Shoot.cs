using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float force = 10f;
    GameObject bulletInstantiate = null;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletInstantiate = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), GetComponentInParent<Transform>().rotation);
            //el fallo es que le estoy añadineod la fuerza segun el valor de x e y, es decir, si esta en x = 3, la bala va mas rapido en x que si va en x = 1
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);
            bulletInstantiate.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x, transform.position.y) * force, ForceMode2D.Impulse);
        }

        if ((bulletInstantiate != null) && (bulletInstantiate.transform.position.x > 11.5 || bulletInstantiate.transform.position.x < -11.5 || bulletInstantiate.transform.position.y > 5.5 || bulletInstantiate.transform.position.y < -5.5))
        {
            Destroy(bulletInstantiate);
        }
    }
}
