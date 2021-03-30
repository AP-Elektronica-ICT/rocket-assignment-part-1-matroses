using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public ScoreHandler scoreHandler;

    private void OnTriggerEnter(Collider other)
    {
        scoreHandler.AddCoin();
        Destroy(gameObject);
    }
}
