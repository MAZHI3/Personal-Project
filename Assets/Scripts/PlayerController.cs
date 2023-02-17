using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float horizontalInput;
    private float range = 20;

    public GameObject trashPrefab;
    public GameObject recyclePrefab;
    public GameObject compostPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move player horizontally
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Player Boundary
        if (transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(trashPrefab, transform.position, trashPrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(recyclePrefab, transform.position, recyclePrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(compostPrefab, transform.position, compostPrefab.transform.rotation);
        }
    }
}
