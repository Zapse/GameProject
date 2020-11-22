using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//just a scene loader for loading previous scene if needed.
public class Level_loadb : MonoBehaviour
{
    private int prevSceneToLoad;

    private void Start()
    {
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(prevSceneToLoad);
    }
}
