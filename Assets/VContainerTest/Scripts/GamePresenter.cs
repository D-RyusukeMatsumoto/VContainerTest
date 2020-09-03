using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;

public class GamePresenter : ITickable
{
    private readonly HelloWorldService hellowWorldService;


    public GamePresenter(
        HelloWorldService _helloWOrldService)
    {
        hellowWorldService = _helloWOrldService;
    }

    public void Tick()
    {
        //hellowWorldService.HelloWorld();
    }
}
