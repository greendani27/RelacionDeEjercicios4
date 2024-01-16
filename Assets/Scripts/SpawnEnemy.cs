using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    
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
            Instantiate(enemy, new Vector3(Random.Range(-10.5f, 7f), Random.Range(0, 4.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(tiempo);
        }
    }
}
