using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while(true){
            int n=Random.Range(1,21);
            if(n==5){
                Debug.Log("The number is 5");
                continue;

            }
            else if(n==15){
                Debug.Log("The number is 15");
                break;
                }
            else Debug.Log(n);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
