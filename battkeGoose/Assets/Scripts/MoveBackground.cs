using UnityEngine;
using UnityEngine.UI;

public class MoveBackground : MonoBehaviour
{

    [SerializeField] private RawImage _image;
    [SerializeField] private float _speed;
    
    void Update()
    {
        InfiniteMove();
    }

    void InfiniteMove()
    {
        _image.uvRect = new Rect(_image.uvRect.position + new Vector2(0, _speed) * Time.deltaTime, _image.uvRect.size);
    }
}
