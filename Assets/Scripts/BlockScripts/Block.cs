using System.Runtime.InteropServices;
using UnityEngine;  
public abstract class  Block : MonoBehaviour,IBlocks
{
    [SerializeField] protected float _fallSpeed;
    private float _acceleration = 9.8f;

    public void FallingBlock(){
        _fallSpeed += _acceleration * Time.deltaTime;
        transform.position += Vector3.down * _fallSpeed * Time.deltaTime;
    }

    public void DeleteBlock(){
                
         if(transform.position.y < -6f)
        {
            GameObject.FindGameObjectWithTag("TextAll").GetComponent<TextScore>().AddScore();
            Destroy(gameObject);
        }
    }
}
