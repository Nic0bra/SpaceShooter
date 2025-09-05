using System.Collections;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public float spawnTime = 2f;
    [SerializeField] public GameObject enemyShip;
    //[SerializeField] private bool gamePlay;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gamePlay = true;
        //StartCoroutine(SpawnShip());
        InvokeRepeating("SpawnShip", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnShip()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-2.5f, 2.5f), 12, 0);
        Instantiate(enemyShip, spawnPosition, Quaternion.identity);
    }

    /*IEnumerator SpawnShip()
    {
        while (gamePlay)
        {
            float spawnPosition = Random.Range(-3, 3);
            Instantiate(enemyShip, new Vector3(spawnPosition, 12f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }*/
}
