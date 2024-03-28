using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public Canvas canvasToActivate;
    public Canvas canvasToDisactivate;
    void Update()
    {
        // Check if the canvas is assigned
        if (Input.GetMouseButtonDown(0))
        {
            // Activate the canvas
            canvasToActivate.gameObject.SetActive(true);
            //Disactivate canvas
            canvasToDisactivate.gameObject.SetActive(false);
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            canvasToActivate.gameObject.SetActive(false);

            canvasToDisactivate.gameObject.SetActive(true);
        }
    }
}
