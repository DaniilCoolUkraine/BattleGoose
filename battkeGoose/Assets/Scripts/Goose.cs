using UnityEngine;

public class Goose : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Loose();
        }
    }

    void Loose()
    {
        Debug.Log("lost");
    }
    
}
