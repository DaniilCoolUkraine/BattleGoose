using UnityEngine;
using UnityEngine.UI;

public class MoveBackground : MonoBehaviour
{
    
    [SerializeField] private RawImage[] _image;
    [SerializeField] private float _speed;
    
    void Update()
    {
        InfiniteMove();
    }

    void InfiniteMove()
    {
        foreach (var image in _image)
        {
            image.uvRect = new Rect(image.uvRect.position + new Vector2(0, _speed) * Time.deltaTime, image.uvRect.size);
        }
    }
}
