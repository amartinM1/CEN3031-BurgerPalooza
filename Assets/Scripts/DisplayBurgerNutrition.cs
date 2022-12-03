using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBurgerNutrition : MonoBehaviour
{
    public static double calories = 0;
    public static double totalFat = 0;
    public static double totalFatDV = 0;
    public static double totalCarbs = 0;
    public static double totalCarbsDV = 0;
    public static double totalSugars = 0;
    public static double protein = 0;
    public static double saturatedFat = 0;
    public static double saturatedFatDV = 0;
    public static double transFat = 0;
    public static double cholesterol = 0;
    public static double cholesterolDV = 0;
    public static double sodium = 0;
    public static double sodiumDV = 0;
    public static double potassiumDV = 0;
    public static double ironDV = 0;
    public static double calciumDV = 0;
    public static double vitaminDDV = 0;
    public static double dietaryFiber = 0;
    public static double dietaryFiberDV = 0;

    public GameObject caloriesObject;
    public GameObject totalFatObject;
    public GameObject totalFatDVObject;
    public GameObject totalCarbsObject;
    public GameObject totalCarbsDVObject;
    public GameObject totalSugarsObject;
    public GameObject proteinObject;
    public GameObject saturatedFatObject;
    public GameObject saturatedFatDVObject;
    public GameObject transFatObject;
    public GameObject cholesterolObject;
    public GameObject cholesterolDVObject;
    public GameObject sodiumObject;
    public GameObject sodiumDVObject;
    public GameObject potassiumDVObject;
    public GameObject ironDVObject;
    public GameObject calciumDVObject;
    public GameObject vitaminDDVObject;
    public GameObject dietaryFiberObject;
    public GameObject dietaryFiberDVObject;
    Text caloriesText;
    Text totalFatText;
    Text totalFatDVText;
    Text totalCarbsText;
    Text totalCarbsDVText;
    Text totalSugarsText;
    Text proteinText;
    Text saturatedFatText;
    Text saturatedFatDVText;
    Text transFatText;
    Text cholesterolText;
    Text cholesterolDVText;
    Text sodiumText;
    Text sodiumDVText;
    Text potassiumDVText;
    Text ironDVText;
    Text calciumDVText;
    Text vitaminDDVText;
    Text dietaryFiberText;
    Text dietaryFiberDVText;

    void Start()
    {
        caloriesText = caloriesObject.GetComponent<Text>();
        totalFatText = totalFatObject.GetComponent<Text>();
        totalFatDVText = totalFatDVObject.GetComponent<Text>();
        totalCarbsText = totalCarbsObject.GetComponent<Text>();
        totalCarbsDVText = totalCarbsDVObject.GetComponent<Text>();
        totalSugarsText = totalSugarsObject.GetComponent<Text>();
        proteinText = proteinObject.GetComponent<Text>();
        saturatedFatText = saturatedFatObject.GetComponent<Text>();
        saturatedFatDVText = saturatedFatDVObject.GetComponent<Text>();
        transFatText = transFatObject.GetComponent<Text>();
        cholesterolText = cholesterolObject.GetComponent<Text>();
        cholesterolDVText = cholesterolDVObject.GetComponent<Text>();
        sodiumText = sodiumObject.GetComponent<Text>();
        sodiumDVText = sodiumDVObject.GetComponent<Text>();
        potassiumDVText = potassiumDVObject.GetComponent<Text>();
        ironDVText = ironDVObject.GetComponent<Text>();
        calciumDVText = calciumDVObject.GetComponent<Text>();
        vitaminDDVText = vitaminDDVObject.GetComponent<Text>();
        dietaryFiberText = dietaryFiberObject.GetComponent<Text>();
        dietaryFiberDVText = dietaryFiberDVObject.GetComponent<Text>();
    }


    void Update()
    {
        calories = (50 * SwitchScenes.cheese) + (300 * SwitchScenes.patties) + (130 * SwitchScenes.buns);
        totalFat = (3.5 * SwitchScenes.cheese) + (25 * SwitchScenes.patties) + (1.5 * SwitchScenes.buns);
        totalFatDV = (5 * SwitchScenes.cheese) + (38 * SwitchScenes.patties) + (2 * SwitchScenes.buns);
        totalCarbs = (2 * SwitchScenes.cheese) + (25 * SwitchScenes.buns);
        totalCarbsDV = (1 * SwitchScenes.cheese) + (9 * SwitchScenes.buns);
        totalSugars = (2 * SwitchScenes.cheese) + (3 * SwitchScenes.buns);
        protein = (3 * SwitchScenes.cheese) + (19 * SwitchScenes.patties) + (4 * SwitchScenes.buns);
        saturatedFat = (2 * SwitchScenes.cheese) + (11 * SwitchScenes.patties);
        saturatedFatDV = (11 * SwitchScenes.cheese) + (55 * SwitchScenes.patties);
        transFat = (1.5 * SwitchScenes.patties);
        cholesterol = (15 * SwitchScenes.cheese) + (65 * SwitchScenes.patties);
        cholesterolDV = (5 * SwitchScenes.cheese) + (22 * SwitchScenes.patties);
        sodium = (230 * SwitchScenes.cheese) + (75 * SwitchScenes.patties) + (230 * SwitchScenes.buns);
        sodiumDV = (10 * SwitchScenes.cheese) + (3 * SwitchScenes.patties) + (10 * SwitchScenes.buns);
        potassiumDV = 0;
        ironDV = (15 * SwitchScenes.patties) + (6 * SwitchScenes.buns);
        calciumDV = (20 * SwitchScenes.cheese) + (4 * SwitchScenes.buns);
        vitaminDDV = (4 * SwitchScenes.cheese);
        dietaryFiber = (2 * SwitchScenes.buns);
        dietaryFiberDV = (7 * SwitchScenes.buns);

        caloriesText.text = calories.ToString("N0");
        totalFatText.text = totalFat.ToString("N0");
        totalFatDVText.text = totalFatDV.ToString("N0");
        totalCarbsText.text = totalCarbs.ToString("N0");
        totalCarbsDVText.text = totalCarbsDV.ToString("N0");
        totalSugarsText.text = totalSugars.ToString("N0");
        proteinText.text = protein.ToString("N0");
        saturatedFatText.text = saturatedFat.ToString("N0");
        saturatedFatDVText.text = saturatedFatDV.ToString("N0");
        transFatText.text = transFat.ToString("N0");
        cholesterolText.text = cholesterol.ToString("N0");
        cholesterolDVText.text = cholesterolDV.ToString("N0");
        sodiumText.text = sodium.ToString("N0");
        sodiumDVText.text = sodiumDV.ToString("N0");
        potassiumDVText.text = potassiumDV.ToString("N0");
        ironDVText.text = ironDV.ToString("N0");
        calciumDVText.text = calciumDV.ToString("N0");
        vitaminDDVText.text = vitaminDDV.ToString("N0");
        dietaryFiberText.text = dietaryFiber.ToString("N0");
        dietaryFiberDVText.text = dietaryFiberDV.ToString("N0");
    }
}