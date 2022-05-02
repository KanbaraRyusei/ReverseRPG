using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : SingletonMonoBehaviour<SceneLoder>
{
    [SerializeField]
    [Header("遷移したいシーン名")]
    string _sceneName;

    [SerializeField]
    [Header("Battleシーンに遷移するか")]
    bool _isBattle = false;

    [SerializeField]
    [Header("BattleManagerのプレハブ")]
    GameObject _battleManager;

    public void SceneLoad()
    {
        SceneManager.LoadSceneAsync(_sceneName);
        if(_isBattle)
        {
            BattleStart();
        }
    }

    void BattleStart()
    {
        Instantiate(_battleManager);
    }
}
