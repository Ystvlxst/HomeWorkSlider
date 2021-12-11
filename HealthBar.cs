using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private HealthValue _healthValue;

    private void Start()
    {
        _slider.value = _healthValue.PlayerHealthValue;
    }
}
