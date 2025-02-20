using Unity.VisualScripting;
using UnityEngine;

public class BlockCoins : AllBlock
{
    private void LateUpdate(){
        FallingBlock();
        DeleteBlock();
    }
    private new void FallingBlock(){base.FallingBlock();}
    private new void DeleteBlock(){
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("TextAll").GetComponent<TextCoins>().TakeCoins();
            GameObject.FindGameObjectWithTag("TextAll").GetComponent<TextScore>().AddScore();
            Destroy(gameObject);
        }
    }
}
