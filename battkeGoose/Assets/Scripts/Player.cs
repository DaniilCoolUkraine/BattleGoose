using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    [SerializeField] 
    private Camera _camera;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        _rigidbody.position = mousePos;
    }
}
