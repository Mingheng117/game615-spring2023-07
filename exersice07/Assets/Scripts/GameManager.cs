using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Image healthImage;
    public PizzaSteve healthPS;
    public GameObject pizzaSteve;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthImage.fillAmount = healthPS.score / 100;

        if (healthPS.score > 99)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject pizza = Instantiate(pizzaSteve, pizzaSteve.transform.position, Quaternion.identity);
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                pizza.transform.Rotate(rotXAmount, rotYAmount, 0);
                pizza.transform.localScale= Vector3.one;
                Rigidbody rb = pizza.GetComponent<Rigidbody>();
                rb.AddForce(pizza.transform.forward * 25);
            }
            pizzaSteve.SetActive(false);

            healthPS.score = 99;
        }
    }
}
