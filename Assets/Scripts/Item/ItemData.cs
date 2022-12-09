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
    [Header("�A�C�e���̖���")]
    private string _name;

    [SerializeField]
    [Header("�A�C�e���̌��ʐ�����")]
    private string _explanatoryText;

    [SerializeField]
    [Header("���ʗ�")]
    private int _value;

    [SerializeField]
    [Header("�l�i")]
    private int _price;

    public abstract void Effect();
}
