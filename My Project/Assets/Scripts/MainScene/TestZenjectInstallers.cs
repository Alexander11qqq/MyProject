using UnityEngine;
using Zenject;

public class TestZenjectInstallers : MonoInstaller
{
    [SerializeField] private GameObject targetPlayer;
    public override void InstallBindings()
    {
        BindPlayer();
    }

    private void BindPlayer ()
    {
        Container.Bind<Player>()
                    .FromComponentOn(targetPlayer)
                    .AsSingle();
    }
}