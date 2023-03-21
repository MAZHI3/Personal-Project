using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    private float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy1Prefab.GameObject.Find("Enemy 1");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // This will be the movement of enemy 1
        if (enemy1Prefab.position.z < 0)
        {
            
        }
        else if (enemy1Prefab.position.z > 16)
        {

        }

        */

        enemy1Prefab.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        enemy2Prefab.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}