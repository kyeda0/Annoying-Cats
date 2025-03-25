using UnityEngine;
using YG;
public class UsualBlock : AllBlock
{
    private void LateUpdate(){
        FallingBlock();
        DeleteBlock();
    }
    private  new void FallingBlock(){base.FallingBlock();}
    private new void DeleteBlock(){base.DeleteBlock();}

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("TextAll").GetComponent<TextScore>().ShowHightScore();
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>()._panels[0].SetActive(false);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>()._panels[1].SetActive(true);
            GameObject.FindGameObjectWithTag("MusicPlayer").GetComponent<Music>()._audio.Pause();
            Time.timeScale = 0;
            if (YandexGame.SDKEnabled)
            {
                YandexGame.FullscreenShow();
            }
        }
    }
}
