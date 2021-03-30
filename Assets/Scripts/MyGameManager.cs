using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public Canvas nextLevelCanvas;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.enabled = false;
        nextLevelCanvas.enabled = false;
    }

    public void endLevel(bool levelCompleted)
    {
        if (levelCompleted)
        {
            nextLevelCanvas.enabled = true;
        }
        else
        {
            gameOverCanvas.enabled = true;
        }
    }
}
