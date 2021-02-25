using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBoundary = 25.0f;
    public float bottomBoundary = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBoundary)
        {
            Destroy(this.gameObject);
        }
        else if (transform.position.z < bottomBoundary)
        {
            Destroy(this.gameObject);
        }
    }
}
