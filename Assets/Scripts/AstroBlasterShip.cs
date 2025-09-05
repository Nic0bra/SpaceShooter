using System.Collections;
using UnityEngine;

public class AstroBlasterShip : MonoBehaviour
{
    public float shipSpeed = 4f;
    public float projectileSpeed = 1000f;
    public float shotTime = .25f;

    public Transform shotSpawn;
    public Rigidbody playerShot;

    [SerializeField] private bool canShoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        float vMove = Input.GetAxisRaw("Horizontal");
        transform.Translate(vMove * shipSpeed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3),
            transform.position.y,
            transform.position.z);

        if (Input.GetButton("Fire1") && canShoot)
        {
            StartCoroutine(FireSpeed());
            Rigidbody _shot;
            _shot = Instantiate(playerShot, shotSpawn.position, shotSpawn.rotation) as Rigidbody;
            _shot.AddForce(shotSpawn.up * projectileSpeed);
        }
    }

    IEnumerator FireSpeed()
    {
        canShoot = false;
        yield return new WaitForSeconds(shotTime);
        canShoot = true;
    }
}
