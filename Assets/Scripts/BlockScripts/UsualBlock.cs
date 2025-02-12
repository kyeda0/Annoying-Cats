using UnityEngine;

public class UsualBlock : Block
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
            GameObject.FindGameObjectWithTag("TextAll").GetComponent<TextScore>().ShowHightScore();
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>()._panels[0].SetActive(false);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>()._panels[1].SetActive(true);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>()._music.Pause();
            Time.timeScale = 0;
        }
    }
}
