using UnityEngine;
using Zenject;

public class SampleMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<A>().AsSingle().NonLazy();
        Container.Bind<B>().AsSingle().NonLazy();
    }

    public class A
    {
        public A()
        {
            Debug.Log($"A");
        }
    }
}

public class B
{
    public B()
    {
        Debug.Log($"B");
    }
}