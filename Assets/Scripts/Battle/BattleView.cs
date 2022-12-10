using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BattleView : MonoBehaviour
{
    [SerializeField]
    [Header("HP")]
    private Slider _hpSlider;

    [SerializeField]
    [Header("MP")]
    private Slider _mpSlider;

    [SerializeField]
    private Button _button;

    [SerializeField]
    private Transform _parent;

    private Button[] _buttons = new Button[0];

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

    public void SetButton(int needNum)
    {
        CheckButtonCount(needNum);
        for(int i = 0; i < needNum; i++)
        {
            _buttons[i].gameObject.SetActive(true);
        }
    }

    public void ButtonTextChenge(string[] texts)
    {
        for(int i = 0; i < texts.Length; i++)
        {
            _buttons[i].gameObject.GetComponentInChildren<Text>().text = texts[i];
        }
    }

    public void ButtonActionChange(Action[] actions)
    {
        for(int i = 0; i < _buttons.Length; i++)
        {
            int x = i;// AddListener—p•Ï”
            _buttons[x].onClick.RemoveAllListeners();
            _buttons[x].onClick.AddListener(() => actions[x]());
        }
    }

    private void CheckButtonCount(int needNum)
    {
        if (_buttons.Length < needNum)
        {
            _buttons = new Button[needNum];
            for (int i = 0; i < _buttons.Length; i++)
            {
                var b = Instantiate(_button);
                _buttons[i] = b;
                b.transform.parent = _parent;
                _buttons[i].gameObject.SetActive(false);
            }
        }
        else
        {
            foreach(var b in _buttons)
            {
                b.gameObject.SetActive(false);
            }
        }
    }
}
