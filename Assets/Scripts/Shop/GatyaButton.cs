using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatyaButton : MonoBehaviour
{
    [SerializeField]
    [Header("�K�`�����񂹂�{�^��")]
    private Button _gachaButton;

    [SerializeField]
    [Header("�V���b�v�}�l�[�W���[")]
    private ShopManager _shopManager;

    private void Awake()
    {
        _gachaButton
            .onClick
            .AddListener(_shopManager.IsTurning);
    }
}
