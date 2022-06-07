using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTank : MonoBehaviour
{
    public float velocidade;
    public float velRotacao;
    void Update()
    {
        MovimentoFrenteTras();
        RotacaoTank();
    }
    void MovimentoFrenteTras()
    {
        Vector3 movimento = new Vector3(velocidade * Input.GetAxis("Vertical") * Time.deltaTime, 0f, 0f);
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(movimento);
        }
    }
    void RotacaoTank()
    {
        Vector3 rotacao = new Vector3(0f, velRotacao * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
        if(Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            transform.eulerAngles += rotacao;
        }
    }
}
