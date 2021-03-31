using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction = new Vector3(-5, 0, 0);
    public float power = 20f;

    void Update()
    {
        transform.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
