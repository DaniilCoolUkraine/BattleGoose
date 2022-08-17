using UnityEngine;

public class ChangeLevels : MonoBehaviour
{

    [SerializeField] private GameObject[] _levels;
    [SerializeField] private bool _setInPlace = true;
    [SerializeField] private float _speed;

    private UIPoints _points;
    
    private void Start()
    {
        _points = gameObject.GetComponent<UIPoints>();
    }
    
    private void Update()
    {
        
        
        
        // if (_points.Points >= 10)// && !setInPlace)
        // {
        //     ChangeLevel();
        //     //setInPlace = false;
        // }
    }

    void ChangeLevel()
    {
        int levelsCount = _levels.Length;
        
        LevelPosition levelPosition;
        for (int i = 0; i < levelsCount - 1; i++)
        {
            levelPosition = _levels[i].GetComponent<LevelPosition>();
            levelPosition.AnchoredPosition -= new Vector2(0, levelPosition.Size.y) * Time.deltaTime * _speed;
        }
        Reorder();
    }

    void Reorder()
    {
        int levelsCount = _levels.Length;
        
        Debug.Log("reorder");
        
        for (int i = 0; i < levelsCount-1; i++)
            (_levels[i], _levels[i+1]) = (_levels[i+1], _levels[i]);
    }
}
