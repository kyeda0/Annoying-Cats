using UnityEngine;  


public class Block : MonoBehaviour
{
    void LateUpdate()
    {
         if(transform.position.y < -6f)
        {
            GameObject.FindGameObjectWithTag("TextScore").GetComponent<TextScore>().AddScore();
            Destroy(gameObject);
        }
    }
}
