using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieEffet : MonoBehaviour
{
    public Image CoffeeFill;
    float CoffeeLevel;
    float maxCoffeeLevel = 100f;

    private void Start()
    {
        CoffeeFill.fillAmount = CoffeeLevel / maxCoffeeLevel;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Zpmbie"))
        {
            CoffeeLevel -= 5f;
        }
    }
}
