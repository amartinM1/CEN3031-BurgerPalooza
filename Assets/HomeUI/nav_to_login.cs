using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nav_to_login : MonoBehaviour
{
   public void MoveToScene(int sceneID){

    SceneManager.LoadScene(sceneID);
   }
}
