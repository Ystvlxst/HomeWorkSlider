using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Button _hit;
    [SerializeField] private Button _healing;

    private PlayerHealthBar _healthBar;

    private float _healthValue;
    private float _changeValue;
    private float _changedHealthValue;
    private float _maxHealth = 100f;
    private float _minHealth = 0f;

    public float PlayerHealthValue => _healthValue;
    public float ChangedHealthValue => _changedHealthValue;

    private void Start()
    {
        _changedHealthValue = _healthValue + _changeValue;

        _changeValue = 10;
        _healthValue = 100f;
    }

    public void Hit()
    {
        ChangeHealth(-_changedHealthValue);
    }

    public void Cure()
    {
        ChangeHealth(_changedHealthValue);
    }

    private void  ChangeHealth(float changedHealthValue)
    {
        _healthValue = Mathf.Clamp(changedHealthValue, _minHealth, _maxHealth);
    }
}
