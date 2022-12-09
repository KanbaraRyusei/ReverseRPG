using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// ガチャのシステムが搭載されているマネージャー
/// プレイヤーとアイテムをください
/// </summary>
public class ShopManager : MonoBehaviour
{
    [SerializeField]
    [Header("値段")]
    private int _price = 100;

    [SerializeField]
    [Header("排出アイテム")]
    private GatyaItem[] _items = new GatyaItem[6];

    const int MAX_VALUE = 100;

    /// <summary>
    /// プレイヤーの金があったらガチャを回せる関数
    /// </summary>
    public void IsTurning()
    {
        //プレイヤーが100ゴールド以上持っていたら
        //_player.Gold >= _price
        if(true)
        {
            //100ゴールド引く
            //_player.AddGold(-100);
            var randomIndex = TurnTheHandle();
            //_player.AddItem(_items[randomIndex].Item);
            Debug.Log(randomIndex);
        }
    }

    /// <summary>
    /// ガチャを回す関数
    /// </summary>
    public int TurnTheHandle() =>
        RandomIndex(_items);

    /// <summary>
    /// ガチャの関数
    /// </summary>
    /// <param name="num">確率</param>
    /// <returns>Index</returns>
    public int RandomIndex(int[] num)
    {
        int[] probability = null;
        var sum = num.Sum();
        var limitCount = 1;
        System.Array.Resize(ref probability, num.Length);
        for (int index = 0; index < num.Length; index++)
        {
            for (int count = 0; count < limitCount; count++)
            {
                probability[index] += num[count] * MAX_VALUE / sum;
            }
            Debug.Log(index + "番目 " + probability[index]);
            limitCount++;
        }
        var randomValue = UnityEngine.Random.Range(0, MAX_VALUE);
        Debug.Log("乱数 " + randomValue);
        for (int i = 0; i < probability.Length; i++)
        {
            if (probability[i] > randomValue)
            {
                Debug.Log("結果は" + i);
                return i;
            }
        }
        return 0;
    }

    /// <summary>
    /// ガチャの関数
    /// </summary>
    /// <param name="num">確率</param>
    /// <returns>Index</returns>
    public int RandomIndex<T>(T[] num) where T : IProbability<T, int>, new()
    {
        return RandomIndex(new T().AllValue(num));
    }

    [Serializable]
    public class GatyaItem : IProbability<GatyaItem, int>
    {
        //public ItemBase Item => _item;
        public int Probability => _probability;

        [SerializeField]
        [Header("アイテム名")]
        string _name = "アイテム";

        //[SerializeField]
        //[Header("アイテム")]
        //ItemBase _item;

        [SerializeField]
        [Header("排出率")]
        int _probability;

        public int[] AllValue(GatyaItem[] gatyaItem)
        {
            return gatyaItem.Select(num => num.Probability).ToArray();
        }
    }
}
