using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] public bool isEnemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyScript eScript = other.gameObject.GetComponent<EnemyScript>();
            eScript.enemyHitCount--;

            if(eScript.enemyHitCount <= 0)
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
