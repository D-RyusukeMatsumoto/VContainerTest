﻿using UnityEngine;

public class HelloWorldService
{

    public void HelloWorld(
        string text)
    {
        Debug.Log($"{text} : HelloWorld");
    }

}
