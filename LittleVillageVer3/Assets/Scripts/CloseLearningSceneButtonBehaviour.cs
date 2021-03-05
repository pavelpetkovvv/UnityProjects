using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseLearningSceneButtonBehaviour : MonoBehaviour
{
    public string SceneToLoad;
    public void CloseBook()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
