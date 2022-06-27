using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RayCastView : MonoBehaviour
{
    public Image mira;
    public Camera tpsCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = tpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawLine(lineOrigin, tpsCamera.transform.forward * Mathf.Infinity, Color.green);
        RaycastHit hitInfo;
        if (Physics.Raycast(lineOrigin, tpsCamera.transform.forward, out hitInfo, Mathf.Infinity))
        {
            if (hitInfo.collider.GetComponent<Alvo>())
            {
                mira.color = Color.red;
            }
            else
            {
                mira.color = Color.green;
            }
        }
    }
}
