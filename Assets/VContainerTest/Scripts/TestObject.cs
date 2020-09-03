using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;

public class TestObject : MonoBehaviour
{
    [Inject]
    private HelloWorldService helloWorldService;


/*
    // コンテナから取得.
    [Inject]
    public void Construct(HelloWorldService _helloWorldService)
    {
        Debug.Log("Inject");
        helloWorldService = _helloWorldService;
    }
*/


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            helloWorldService.HelloWorld("TestObject");
        }
    }
}
