using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoffeeBar : MonoBehaviour
{
    public Image CoffeeFill;

    public float CoffeeLevel;
    float maxCoffeeLevel = 100f;
    void Start()
    {

        CoffeeLevel = maxCoffeeLevel;
        CoffeeFill.fillAmount = CoffeeLevel/maxCoffeeLevel;
    }
    void Update()
    {
        CoffeeFill.fillAmount = CoffeeLevel / maxCoffeeLevel;

        CoffeeLevel -= 1f * Time.deltaTime;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        { 
            CoffeeLevel -=2f * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            CoffeeLevel -= 5f * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CoffeeLevel -= 10f;
        }

        if(CoffeeLevel <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

