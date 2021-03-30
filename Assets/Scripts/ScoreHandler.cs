using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    public void AddCoin()
    {
        coins++;
        Debug.Log(coins);
    }
}
