using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        Health.OnButtonClicked += OnButtonClicked;
    }

    private void OnDisable() 
    {
        Health.OnButtonClicked -= OnButtonClicked;
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

    private void OnButtonClicked()
    {
        Startcorutine(ChangeSliderValue());
    }
}
