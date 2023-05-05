using UnityEngine;
using Zenject;

public class CreateEnemies : MonoBehaviour
{
    [SerializeField, Inject] private DiContainer _diContainer;
    [SerializeField] private GameObject enemy;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        _diContainer.InstantiatePrefab(enemy, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity, null);
    }
}
