using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSingleton : MonoBehaviour
{
    public static SceneManagerSingleton sceneManager { get; private set; }
    void Awake()
    {
        sceneManager = this;
    }
    public void LoadSystem(string sceneName) 
    {
        StartCoroutine(ILoadSystem(sceneName));
    }
    IEnumerator ILoadSystem(string sceneName)
    {
        AsyncOperation asyncLoad1 = SceneManager.LoadSceneAsync("Main", LoadSceneMode.Single);

        while (!asyncLoad1.isDone)
        {
            yield return null;
        }
        StartCoroutine(LoadSceneAndSetActive(sceneName));
    }
    IEnumerator LoadSceneAndSetActive(String sceneName)
    {
        AsyncOperation asyncLoad2 = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        while (!asyncLoad2.isDone)
        {
            yield return null;
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
    }
    public void Reset()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
