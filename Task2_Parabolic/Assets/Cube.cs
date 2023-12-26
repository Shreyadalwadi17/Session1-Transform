using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;
    public float duration = 2f;

    private float startTime;
    private Vector3 startPos;
    private Vector3 endPos;
    bool call = false;
    public Vector3 cube;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        startPos = startPoint.position;
        endPos = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (call == true)
        {
            float t = (Time.time - startTime) / duration;
            t = Mathf.Clamp01(t);
            float height = Mathf.Sin(t * Mathf.PI) * 2f;
            transform.position = Vector3.Lerp(startPos, endPos, t) + Vector3.up * height;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            call = true;
        }
        else
        {

        }

    }
}