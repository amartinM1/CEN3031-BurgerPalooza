using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NutritionDropdown : MonoBehaviour
{
    public Image oldImage;
    public Sprite[] newImage;
    public Dropdown burgerDropdown;

    public void changeImage(Dropdown burgerDropdown)
    {
        oldImage.sprite = newImage[burgerDropdown.value];
    }
}
