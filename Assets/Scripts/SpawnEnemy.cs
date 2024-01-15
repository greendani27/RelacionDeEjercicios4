using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawn();
    }

    public void StartSpawn()
    {
        StartCoroutine(Create(3f));
    }

    private IEnumerator Create(float tiempo)
    {
        while (true)
        {
            Instantiate(enemy, new Vector3(Random.Range(-10.5f, 10.5f), Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(tiempo);
        }
    }
}
