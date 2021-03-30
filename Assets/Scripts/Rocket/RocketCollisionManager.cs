using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollisionManager : MonoBehaviour
{
    public MyGameManager gameManager;

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
        if (gameObject.transform.rotation.z > 30 || gameObject.transform.rotation.z < -30)
        {
            gameManager.endLevel(false);
        }
        if (collision.gameObject.name == "LandingPad"
            && gameObject.transform.position.x < collision.gameObject.transform.position.x + 1.5
            && gameObject.transform.position.x > collision.gameObject.transform.position.x - 1.5)
        {
            gameManager.endLevel(true);
        }
    }
}
