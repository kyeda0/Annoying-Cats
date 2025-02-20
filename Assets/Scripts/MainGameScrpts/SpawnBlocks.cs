using System.Collections;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


public class SpawnBlocks : MonoBehaviour
{
    [SerializeField] private GameObject[] _blocks;
    [SerializeField] private float _maxX;
    [SerializeField] private float _timeToSpawn;


    public  void StartSpawning()
    {
        StartCoroutine(ISpawnBlock());
    }
     private void SpawnBlock()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(-_maxX, _maxX);
        var _random = Random.Range(0,_blocks.Length);
        Instantiate(_blocks[_random], spawnPos, Quaternion.identity); 
    }

    IEnumerator ISpawnBlock(){
        while(true){
            yield return new WaitForSeconds(_timeToSpawn);
            SpawnBlock();
            if(GameObject.FindWithTag("TextAll").GetComponent<TextScore>()._currentScore %10 ==0){
                if(_timeToSpawn <= 0.9f){
                    _timeToSpawn = 0.9f;
                }
                else{
                    _timeToSpawn -=0.1f;
                }
            }
        }
    }
}
