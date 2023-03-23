using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyV : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemyRb.position.z <= 0)
        {
            transform.Rotate(0, -180, 0);
        }
        else if (enemyRb.position.z > 16)
        {
            transform.Rotate(0, 180, 0);
        }
        enemyRb.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
