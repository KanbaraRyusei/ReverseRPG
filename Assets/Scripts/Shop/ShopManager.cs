using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// �K�`���̃V�X�e�������ڂ���Ă���}�l�[�W���[
/// �v���C���[�ƃA�C�e������������
/// </summary>
public class ShopManager : MonoBehaviour
{
    [SerializeField]
    [Header("�l�i")]
    private int _price = 100;

    [SerializeField]
    [Header("�r�o�A�C�e��")]
    private GatyaItem[] _items = new GatyaItem[6];

    [SerializeField]
    [Header("�v���C���[")]
    BattlePlayer _player;

    const int MAX_VALUE = 100;

    /// <summary>
    /// �v���C���[�̋�����������K�`�����񂹂�֐�
    /// </summary>
    public void IsTurning()
    {
        //�v���C���[��100�S�[���h�ȏ㎝���Ă�����
        
        if(_player.Gold >= _price)
        {
            //100�S�[���h����
            _player.AddGold(-_price);
            var randomIndex = TurnTheHandle();
            _player.GetItem(_items[randomIndex].Item);
            Debug.Log(_items[randomIndex].Item.Name);
        }
    }

    /// <summary>
    /// �K�`�����񂷊֐�
    /// </summary>
    public int TurnTheHandle() =>
        RandomIndex(_items);

    /// <summary>
    /// �K�`���̊֐�
    /// </summary>
    /// <param name="num">�m��</param>
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
            Debug.Log(index + "�Ԗ� " + probability[index]);
            limitCount++;
        }
        var randomValue = UnityEngine.Random.Range(0, MAX_VALUE);
        Debug.Log("���� " + randomValue);
        for (int i = 0; i < probability.Length; i++)
        {
            if (probability[i] > randomValue)
            {
                Debug.Log("���ʂ�" + i);
                return i;
            }
        }
        return 0;
    }

    /// <summary>
    /// �K�`���̊֐�
    /// </summary>
    /// <param name="num">�m��</param>
    /// <returns>Index</returns>
    public int RandomIndex<T>(T[] num) where T : IProbability<T, int>, new()
    {
        return RandomIndex(new T().AllValue(num));
    }

    [Serializable]
    public class GatyaItem : IProbability<GatyaItem, int>
    {
        public ItemData Item => _item;
        public int Probability => _probability;

        [SerializeField]
        [Header("�A�C�e����")]
        string _name = "�A�C�e��";

        [SerializeField]
        [Header("�A�C�e��")]
        ItemData _item;

        [SerializeField]
        [Header("�r�o��")]
        int _probability;

        public int[] AllValue(GatyaItem[] gatyaItem)
        {
            return gatyaItem.Select(num => num.Probability).ToArray();
        }
    }
}
