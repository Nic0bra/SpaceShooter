using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] public float _frequency = 6f;
    [SerializeField] public float _distance = 0.75f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -2.5f * Time.deltaTime, 0);
        transform.Rotate(0, 5f, 0);
        transform.position = new Vector3(XSine(), transform.position.y, transform.position.z);
    }

    public float XSine()
    {
        return Mathf.Sin(Time.time * _frequency) * _distance;
    }
}
