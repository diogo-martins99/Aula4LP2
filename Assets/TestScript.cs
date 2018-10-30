using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    private Coroutine sayHello;
    private Coroutine printNumbers;
    private int n = 0;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("PrintNumbers");
        StartCoroutine("PrintHello");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator PrintHello()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            print("Hello");
        }
    }

    IEnumerator PrintNumbers()
    {
        while (true)
        {
            print(n);
            n++;
            yield return new WaitForSeconds(1);
            if (n == 5) StopCoroutine("PrintHello");
        }
    }

}
