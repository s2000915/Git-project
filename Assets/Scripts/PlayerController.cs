using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    public float speed = 10f;
    public float xRange = 10;
    public float zRange = -10;

    public GameObject Projectileprefab;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < zRange) 
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Projectileprefab, transform.position, Projectileprefab.transform.rotation);
        }

        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
    }
}
