using UnityEngine;

public class ChangeLevels : MonoBehaviour
{

    [SerializeField] private GameObject[] _levels;
    [SerializeField] private float _speed;

    private UIPoints _points;

    public bool changedState = false;
    
    private void Start()
    {
        _points = gameObject.GetComponent<UIPoints>();
    }
    
    private void Update()
    {
        SetNextLevelPosition();
        
        if (_points.enabled && _points.Points >= 1 && Mathf.Round(_points.Points) % 20 == 0 && !changedState)
        {
            ChangeLevelState(false);
            Reorder();
            changedState = true;
        }
        
        ChangeLevel();
    }

    void ChangeLevelState(bool state)
    {
        int levelsCount = _levels.Length;
        
        LevelPosition level;
        for (int i = 0; i < levelsCount; i++)
        {
            level = _levels[i].GetComponent<LevelPosition>();
            level.SetInPlace = state;
            
            // Debug.Log("false");
            // Debug.Log($"{level.gameObject.name} finalPosition set in {level.FinalPosition}");
            // Debug.Log($"{level.gameObject.name} firstPosition set in {level.FirstPosition}");
        }
    }

    void SetNextLevelPosition()
    {
        int levelsCount = _levels.Length;
        
        LevelPosition level;
        for (int i = 0; i < levelsCount - 1; i++)
        {
            level = _levels[i].GetComponent<LevelPosition>();
            if (level.SetInPlace)
            {
                level.FinalPosition = _levels[i + 1].GetComponent<LevelPosition>().FirstPosition;
                _levels[levelsCount-1].GetComponent<LevelPosition>().FinalPosition = _levels[0].GetComponent<LevelPosition>().FirstPosition;
            }
        }
    }
    
    void ChangeLevel()
    {
        int levelsCount = _levels.Length;
        
        LevelPosition level; 
        for (int i = 0; i < levelsCount; i++) 
        { 
            level = _levels[i].GetComponent<LevelPosition>();
            if (!level.SetInPlace)
            {
                level.MoveToScreen(_speed);
            }
        }
    }

    void Reorder()
    {
        int levelsCount = _levels.Length;
        
        for (int i = 0; i < levelsCount - 1; i++)
            (_levels[i], _levels[i+1]) = (_levels[i+1], _levels[i]);
    }
}
