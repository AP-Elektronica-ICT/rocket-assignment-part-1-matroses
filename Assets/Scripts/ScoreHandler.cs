using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Text coinsText;

    private int coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    public void AddCoin()
    {
        coins++;
        coinsText.text = coins.ToString();
        //Debug.Log(coins);
    }
}
