using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplysch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i=1;
        while(i<=5){
            int j=1;
            while(j<=5){
                int res=i*j;
                Debug.Log(i + " * "+ j + " = " + res);



                j++;
            }
            i++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
