using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ItemData", fileName ="ItemData")]
public abstract class ItemData : ScriptableObject
{
    public string Name => _name;
    public string ExplanatoryText => _explanatoryText;
    public int Value => _value;
    public int Price => _price;

    [SerializeField]
    [Header("アイテムの名称")]
    private string _name;

    [SerializeField]
    [Header("アイテムの効果説明文")]
    private string _explanatoryText;

    [SerializeField]
    [Header("効果量")]
    private int _value;

    [SerializeField]
    [Header("値段")]
    private int _price;

    public abstract void Effect();
}
