using UnityEngine;

public class EnemyShootScript : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] public float speed;
    [SerializeField] Rigidbody enemyShot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyShot = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector3 moveDir = (target.transform.position -transform.position).normalized * speed;
        enemyShot.linearVelocity = new Vector3(moveDir.x, moveDir.y, moveDir.z);
    }
}
