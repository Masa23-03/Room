using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] randomWords=new string[10] {"Cat" , "Dog" , "Car" , "Pizza" , "hat" , "Fish" ,
        "Tree" , "Monkey" , "Ball" , "Bird"};
        int i =1;
        string sentense="";
        while(i<=7){
            int wordIndex=Random.Range(0,7);
            string word=randomWords[wordIndex];
            sentense+=word;
            sentense+=" ";
            i++;

        }
        Debug.Log(sentense);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
