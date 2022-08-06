using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 100;
        int num2 = num1;
        int num3 = method(num1);
        
    }

    int method(int num)
    {
        num = num * 2;
        return num;
    }

    // Update is called once per frame
    void Update()
    {
        method(2);
    }
}
