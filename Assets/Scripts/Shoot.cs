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
            bulletInstantiate.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * force, ForceMode2D.Impulse);
        }

        if ((bulletInstantiate != null) && bulletInstantiate.transform.position.y > 5.5) {
            Destroy(bulletInstantiate);
        }
    }
}
