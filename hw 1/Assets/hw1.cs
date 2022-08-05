using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw1 : MonoBehaviour
{
    string hero = "thamer";
    int health = 100;
    int damaged_health;
    int damaged()
    {
        return health - 20;
    }
    int boost()
    {
        return damaged_health + 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        damaged_health = damaged();
        print("damaged health " + damaged_health);
        print(" boost health " + boost());

        if(boost() > damaged_health)
        {
            print(boost());
        }
        else if(boost() == damaged_health)
        {
            print(boost() + "=" + damaged_health );
        }
        else
        {
            print(damaged_health);
        }
        print("80 is less than 90");
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
    
 
}   
    
