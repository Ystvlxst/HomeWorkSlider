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

    private void Hit()
    {
        _healthValue.Hit();
        StopCoroutine(ChangeSliderValue(_healthValue.ChangedHealthValue));
        StartCoroutine(ChangeSliderValue(-_healthValue.ChangedHealthValue));
    }

    private void Cure()
    {
        _healthValue.Cure();
        StopCoroutine(ChangeSliderValue(-_healthValue.ChangedHealthValue));
        StartCoroutine(ChangeSliderValue(_healthValue.ChangedHealthValue));
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
}
