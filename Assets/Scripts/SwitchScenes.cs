using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
	//I think these values needs to be here since we want them to be called once...
	public static List<GameObject> bun_sprites = new List<GameObject>();
    public static int patties = 0;
    public static int buns = 0;
    public static int cheese = 0;
	
    public void playGame()
    {
        SceneManager.LoadScene("BurgerNutrition");
    }
}
