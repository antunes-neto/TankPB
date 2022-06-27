using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
   
    public Transform rotacaoTorreta;

    float rotacaoX = 0;
    float rotacaoY = 0;
    private void Awake()
    {
    }

    


    // Update is called once per frame
    void Update()
    {
        RotacaoCameraCNTRL();

    }
    void RotacaoCameraCNTRL()
    {
        float verticalDelta = Input.GetAxisRaw("Mouse Y");
        float horizontalDelta = Input.GetAxisRaw("Mouse X");

        rotacaoX += horizontalDelta;
        rotacaoY += verticalDelta;

        rotacaoTorreta.localEulerAngles = new Vector3(0f, rotacaoX, 0f);

        transform.localEulerAngles = new Vector3(-rotacaoY, 0f, 0f);
    }
}
