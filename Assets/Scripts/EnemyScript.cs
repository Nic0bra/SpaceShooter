using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 4f;
    [SerializeField] public float _frequency = 6f;
    [SerializeField] public float _distance = 0.75f;

    [SerializeField] public int enemyHitCount = 5;

    [SerializeField] Vector3 _position;
    [SerializeField] float sinCenterX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sinCenterX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Translate(0, -2.5f * Time.deltaTime, 0);
        transform.Rotate(0, 5f, 0);
        transform.position = new Vector3(XSine(), transform.position.y, transform.position.z);
        */

        _position = transform.position;
        float _sin = Mathf.Sin(_position.y * _frequency) * _distance;
        _position.x = sinCenterX + _sin;

        _position.y -= moveSpeed * Time.deltaTime;
        transform.Rotate(0, 5f, 0);
        transform.position = _position;
    }

    public float XSine()
    {
        return Mathf.Sin(Time.time * _frequency) * _distance;
    }
}
