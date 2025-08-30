using UnityEngine;

public class AstroBlasterShip : MonoBehaviour
{
    public float shipSpeed = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(vMove * shipSpeed * Time.deltaTime, 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3),
            transform.position.y,
            transform.position.z);
    }
}
