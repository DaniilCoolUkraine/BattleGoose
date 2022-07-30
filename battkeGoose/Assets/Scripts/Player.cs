using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    [SerializeField] 
    private Camera _camera;

    private Vector2 _mousePos;
    
    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        _rigidbody.position = _mousePos;
    }
}
