using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
    string heroname = " salem ";
    int hreoHeight =  170 ;
    int heroage =  35 ;
    string herosuperpower = " super strength ";
    string villainname = " ahmed ";
    int villianHeight = 168 ;
    int villianage = 33 ;
    string villiansuperpower = " invisibility ";

    // Start is called before the first frame update
    void Start()
    {
        int agedifference = heroage - villianage;
        print(" the hero's name is " + heroname + " and his height is " + hreoHeight + " and his age is " + heroage + " and his super power is " + herosuperpower);
        print(" the villian's name is " + villainname + " and his height is " + villianHeight + " and his age is " + villianage + " and his super power is " + villiansuperpower );
        print(" agedifference is " + agedifference);
        hreoHeight += 5;
        print(hreoHeight);
        villiansuperpower = "none";
        print("The villian lost his super power becuase of his last fight" + villiansuperpower);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

