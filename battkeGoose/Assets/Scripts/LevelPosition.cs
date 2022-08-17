using UnityEngine;

public class LevelPosition : MonoBehaviour
{
    public Vector2 AnchoredPosition
    {
        get
        {
            return gameObject.GetComponent<RectTransform>().anchoredPosition;
        }
        set
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = value;
        }
    }

    public Vector2 Size
    {
        get
        {
            return gameObject.GetComponent<RectTransform>().sizeDelta;
        }
    }
}
