using Unity.VisualScripting;
using UnityEngine;

public class BlockCoins : Block
{
    private void LateUpdate(){
        FallingBlock();
        DeleteBlock();
    }
    public new void FallingBlock(){base.FallingBlock();}
    public new void DeleteBlock(){base.DeleteBlock();}
     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("TextAll").GetComponent<TextCoins>().TakeCoins();
            Destroy(gameObject);
        }
    }
}
