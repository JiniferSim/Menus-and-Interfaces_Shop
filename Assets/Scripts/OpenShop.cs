using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public Canvas canvasToActivate;
    void Update()
    {
        // Check if the canvas is assigned
        if (Input.GetMouseButtonDown(0))
        {
            // Activate the canvas
            canvasToActivate.gameObject.SetActive(true);
        }
    }
}
