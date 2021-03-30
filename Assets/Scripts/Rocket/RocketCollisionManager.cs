using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "LandingPad"
            && gameObject.transform.position.x < collision.gameObject.transform.position.x + 1.5
            && gameObject.transform.position.x > collision.gameObject.transform.position.x - 1.5)
        {
            Destroy(gameObject);
        }
    }
}
