using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBurger : MonoBehaviour
{
		void OnMouseDown()
	{
		foreach (GameObject sprite in SwitchScenes.bun_sprites)
		{
			Destroy(sprite);
		}
		SwitchScenes.bun_sprites.Clear();
		MoveToBun.offset = 0;
		SwitchScenes.patties = 0;
		SwitchScenes.cheese = 0;
		SwitchScenes.buns = 0;
	}
}
