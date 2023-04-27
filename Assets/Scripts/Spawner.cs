using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _secondsBetweenSpawns;

    private float _elapsedTime = 0;
    
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        
        if (_elapsedTime < _secondsBetweenSpawns)
        {
            return;
        }

        _elapsedTime = 0;

        int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
        Instantiate(_enemy, _spawnPoints[spawnPointNumber].position, Quaternion.identity);
    }
}
