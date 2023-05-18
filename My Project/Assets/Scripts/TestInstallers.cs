using UnityEngine;
using Zenject;

public class TestInstallers : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.
            Bind<string>().
            FromInstance("Hello, Mavrinka, my friend");

        Container.
            Bind<Greeter>().
            AsSingle().
            NonLazy();
    }
}

public class Greeter
{
    public Greeter(string message)
    {
        Debug.Log(message);
    }
}