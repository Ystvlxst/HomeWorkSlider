using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthValue : MonoBehaviour
{
    [SerializeField] private Button _hit;
    [SerializeField] private Button _healing;

    private float _healthValue;
    private float _changeValue;
    private float _maxHealth = 100f;
    private float _minHealth = 0f;
    
    public float PlayerHealthValue => _healthValue;

    private void Start()
    {
        _changeValue = 10;
        _healthValue = 100f;
    }

    private void Hit()
    {
        if(_healthValue > _minHealth)
        _healthValue -= _changeValue;

        _healthValue = _minHealth;
    }

    private void Healing()
    {
        if(_healthValue < _maxHealth)
        _healthValue += _changeValue;

        _healthValue = _maxHealth;
    }
}