using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollisionManager : MonoBehaviour
{
    public MyGameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Enemy")
        {
            gameManager.endLevel(false);
        }
        if (collision.gameObject.name == "LandingPad"
            && gameObject.transform.position.x < collision.gameObject.transform.position.x + 1.5
            && gameObject.transform.position.x > collision.gameObject.transform.position.x - 1.5)
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            gameManager.endLevel(true);
        }
    }
}
