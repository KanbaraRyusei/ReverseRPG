using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatyaButton : MonoBehaviour
{
    [SerializeField]
    [Header("ガチャを回せるボタン")]
    private Button _gachaButton;

    [SerializeField]
    [Header("ショップマネージャー")]
    private ShopManager _shopManager;

    private void Awake()
    {
        _gachaButton
            .onClick
            .AddListener(_shopManager.IsTurning);
    }
}
