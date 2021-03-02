using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparklesCollision : MonoBehaviour
{

    public GameObject snakePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Instantiate(snakePrefab, col.transform.position, col.transform.rotation);
        }
    }
}
