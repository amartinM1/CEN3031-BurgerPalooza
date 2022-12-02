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
		
		SwitchScenes.bun_values.Clear();
	}
}
