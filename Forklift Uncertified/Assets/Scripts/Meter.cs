using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Meter : MonoBehaviour
{
    [SerializeField] Transform point;

    [SerializeField] TextMeshProUGUI distanceText;

    float distance;

    void Update()
    {
        distance = (point.transform.position - transform.position).magnitude;
        distanceText.text = distance.ToString("F1") + "Meter";
    }
}
