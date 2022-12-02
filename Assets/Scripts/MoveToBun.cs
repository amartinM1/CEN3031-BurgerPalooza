using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToBun : MonoBehaviour
{
    public GameObject sprite;
	public static int offset;
	public int cal_value;
	
	void OnMouseDown()
	{
		var new_sprite = Instantiate(sprite, new Vector3(-0.04f, (-0.29f+offset), 0), transform.rotation);
		offset += 1;
		SwitchScenes.bun_sprites.Add(new_sprite);
		SwitchScenes.bun_values.Add(cal_value);
	}
}

//There will be a variable that will hold the amounts of ingridents there are in the game, 
//it will only permit a certain amount of ingredents after that amount is equal to the ingame amount. 
//you will only can put the top bun in your buger to get your nutrition facts