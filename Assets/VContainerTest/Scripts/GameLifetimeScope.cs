using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{

    [SerializeField] private TestObject testObject;


    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<HelloWorldService>(Lifetime.Scoped);
        builder.RegisterEntryPoint<GamePresenter>(Lifetime.Singleton);

        // TODO : GameObjectとの紐付け( これ以外の方法があるかはまだわからない ).
        builder.RegisterComponent(testObject);
    }

}
