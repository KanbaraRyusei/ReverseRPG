using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleView : MonoBehaviour
{
    [SerializeField]
    [Header("HP")]
    private Slider _hpSlider;

    [SerializeField]
    [Header("MP")]
    private Slider _mpSlider;

    [SerializeField]
    [Header("コマンドのボタン")]
    private Button _buttons;

    public void SetMaxHP(float value)
    {
        _hpSlider.maxValue = value;
    }

    public void SetMaxMP(float value)
    {
        _mpSlider.maxValue = value;
    }

    public void SetHP(float value)
    {
        _hpSlider.value = value;
    }

    public void SetMP(float value)
    {
        _mpSlider.value = value;
    }
}
