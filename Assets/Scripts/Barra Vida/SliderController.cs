using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderController : MonoBehaviour
{
    public Slider miSlider;

  public void UpdateSlider(float newFillAmount)
    {
        miSlider.value = newFillAmount;
    }
}
