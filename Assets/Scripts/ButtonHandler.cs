using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void OpenLevel(int level) //int level
    {
        SceneManager.LoadScene(sceneName: "Assets/Scenes/Levels/Level" + level + ".unity");
    }
}
