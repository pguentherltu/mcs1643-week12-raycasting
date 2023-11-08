using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaycastingDemo : MonoBehaviour
{
    public TextMeshProUGUI objectTMP;
    public TextMeshProUGUI distanceTMP;

    private RaycastHit hit;
    private Vector3 raycastOriginOffset = new Vector3(0, .75f, 0);

    void Update()
    {
        bool result = Physics.Raycast(
            transform.position + raycastOriginOffset,
            transform.forward,
            out hit,
            20.0f
        );

        if (result)
        {
            objectTMP.text = hit.collider.transform.name;
            distanceTMP.text = hit.distance.ToString();  
        }
        else
        {
            objectTMP.text = "No hit detected";
            distanceTMP.text = "--";
        }
    }
}
