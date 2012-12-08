using UnityEngine;
using System.Collections;

public class MyPlayerAsset : ScriptableObject
{
    public string _playerName;
    public MyPlayerAsset(string playName)
    {
        _playerName = playName;
    }
}
