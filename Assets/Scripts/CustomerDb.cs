using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDb : MonoBehaviour
{
    public Customer[] customers;

    [SerializeField] private Customer kathy, kelly, devan, eric;

    // Start is called before the first frame update
    void Start()
    {
        //kathy = CreateCustomer("Kathy", "Morgan", 52, "Female", "Wife");
        kathy = new Customer("Kathy", "Morgan", 52, "Female", "Wife");
        
        kelly = CreateCustomer("Kelly", "Morgan", 13, "Female", "Daughter");
        devan = CreateCustomer("Devan", "Morgan", 18, "Male", "Son");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Customer CreateCustomer(string firstName, string lastName, int age, string gender, string occupation)
    {
        var customer = new Customer(firstName, lastName, age, gender, occupation);

        return customer;

    }

}
