using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaycastingDemo : MonoBehaviour
{
    public TextMeshProUGUI objectTMP;
    public TextMeshProUGUI distanceTMP;
    public Vector3 raycastOriginOffset = new Vector3(0, .75f, 0);

    private RaycastHit hit;
    private LayerMask mask;

    private void Start()
    {
        mask =~ LayerMask.GetMask("Invisible");
    }

    void FixedUpdate()
    {
        bool result = Physics.Raycast(
            transform.position + raycastOriginOffset,
            transform.forward,
            out hit,
            20.0f,
            mask
        );

        if (result)
            
        {
            objectTMP.text = hit.transform.name;
            distanceTMP.text = hit.distance.ToString();  
        }
        else
        {
            objectTMP.text = "No hit detected";
            distanceTMP.text = "--";
        }
    }
}
