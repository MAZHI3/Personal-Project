using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyH : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyRb.position.x < -19)
        {
            transform.Rotate(0, -180, 0);
        }
        else if (enemyRb.position.x > 19)
        {
            transform.Rotate(0, 180, 0);
        }
        enemyRb.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
