using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    private Vector3 targetposition;
    private float movementspeed = 5f;
    public GameObject Point1;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            targetposition = new Vector3(Random.Range(-5, 5), Random.Range(4, -4), 0f);
            Point1.transform.position = targetposition;
            transform.up = targetposition - transform.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, Point1.transform.position, movementspeed * Time.deltaTime);


    }
}