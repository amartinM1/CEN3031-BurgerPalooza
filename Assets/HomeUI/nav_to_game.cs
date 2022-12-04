using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nav_to_game : MonoBehaviour
{
    public int sceneID;
    public Slider loadingBar;
    public GameObject loadingScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadToGame(sceneID));
    }

    public IEnumerator LoadToGame(int sceneID){
        yield return new WaitForSeconds(2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        loadingScreen.SetActive(true);
        while(!operation.isDone){

           loadingBar.value = operation.progress;
           yield return null; 
        }

    }
}
