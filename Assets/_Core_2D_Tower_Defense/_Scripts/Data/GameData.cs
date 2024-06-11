using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Data/Game Data")]
public class GameData : ScriptableObject
{
    public List<SeasonData> listSeasonData;
}

[Serializable]
public class SeasonData
{
    public List<LevelData> listLevelData;
}