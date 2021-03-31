using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Bullet bulletPrefab;
    public List<Bullet> bullets = new List<Bullet>();

    public ParticleSystem shot;

    public Vector3 pos;

    public int interval = 50;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(-2.548702f, 7.292f, 1.005873f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % interval == 0)
        {
            //bullets.Add(new Bullet());
            shot.Play();
            bullets.Add(Instantiate(bulletPrefab, pos, transform.rotation));
        }

    }
}
