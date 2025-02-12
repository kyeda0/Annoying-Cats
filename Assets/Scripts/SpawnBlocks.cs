using UnityEngine;


public class SpawnBlocks : MonoBehaviour
{
    [SerializeField] private GameObject[] _blocks;
    [SerializeField] private float _maxX;
    [SerializeField] private  float _spawnRate;
    [SerializeField] private float _timeToSpawn;


    public  void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", _timeToSpawn, _spawnRate);
    }
     private void SpawnBlock()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(-_maxX, _maxX);
        var _random = Random.Range(0,_blocks.Length);
        Instantiate(_blocks[_random], spawnPos, Quaternion.identity); 
    }
}
