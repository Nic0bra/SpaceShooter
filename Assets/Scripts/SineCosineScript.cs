using UnityEngine;

public class SineCosineScript : MonoBehaviour
{

    public Vector3 _distance;
    public Vector3 _moveFreq;
    Vector3 movePosition;
    Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movePosition.x = startPosition.x + Mathf.Sin(Time.timeSinceLevelLoad * _moveFreq.x) * _distance.x;
        movePosition.y = startPosition.y + Mathf.Sin(Time.timeSinceLevelLoad * _moveFreq.y) * _distance.y;
        movePosition.z = startPosition.z + Mathf.Sin(Time.timeSinceLevelLoad * _moveFreq.z) * _distance.z;
    }
}
