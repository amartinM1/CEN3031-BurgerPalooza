using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("BurgerNutrition");
    }
}
