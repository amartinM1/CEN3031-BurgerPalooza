using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
	//I think these values needs to be here since we want them to be called once...
	public static List<GameObject> bun_sprites = new List<GameObject>();
	public static List<int> bun_values = new List<int>();
	
    public void playGame()
    {
        SceneManager.LoadScene("BurgerNutrition");
    }
}
