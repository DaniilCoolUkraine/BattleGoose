using System.Collections;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    [SerializeField] private float _waitSec;
    
    void Start()
    {
        StartCoroutine(DeleteCoroutine());
    }
    
    IEnumerator DeleteCoroutine()
    {
        yield return new WaitForSeconds(_waitSec);
        Destroy(gameObject);
    }
}
