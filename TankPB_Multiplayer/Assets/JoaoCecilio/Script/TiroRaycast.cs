using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroRaycast : MonoBehaviour
{
    public Camera tpsCamera;

    private void Update()
    {
        ShootRaycast();
    }
    void ShootRaycast()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 rayOrigin = tpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, tpsCamera.transform.forward,out hitInfo, Mathf.Infinity))
            {
                Alvo vida = hitInfo.collider.GetComponent<Alvo>();
                if (vida != null)
                {
                    vida.Dano(1);
                }
                
            }
        }
        
    }
}
