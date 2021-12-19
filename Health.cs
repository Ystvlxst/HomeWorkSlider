
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private float _value;
    private float _changedValue;
    private float _maxHealth = 100f;
    private float _minHealth = 0f;

    public event UnityAction Changed;

    private void Start()
    {
        _value = 100f;
    }

    public void Hit()
    {
        ChangeHealth(-_changedValue);
    }

    public void Cure()
    {
        ChangeHealth(_changedValue);
    }

    private void ChangeHealth(float changedValue)
    {
        Changed?.invoke();
        float changeValue = 10f;
        changedValue = _value + changeValue;
        _value = Mathf.Clamp(changedValue, _minHealth, _maxHealth);
    }
}
