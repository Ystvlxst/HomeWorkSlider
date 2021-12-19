using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private Health _health;

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }

    public IEnumerator ChangeSliderValue(float targetValue)
    {
        float maxDelta = 0.1f;

        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, maxDelta);
            yield return null;
        }
    }

    private void OnHealthChanged()
    {
        Startcorutine(ChangeSliderValue());
    }
}
