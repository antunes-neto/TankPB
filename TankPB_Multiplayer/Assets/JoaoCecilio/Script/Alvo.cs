using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alvo : MonoBehaviour
{
    public int vidaAtual;
    public int vidaMax;
    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig.useGravity = false;
        vidaAtual = vidaMax;
    }
    public void Dano(int danoRecebido)
    {
        if (vidaAtual >= vidaMax)
        {
            vidaAtual -= danoRecebido;
            if (vidaAtual <= 0)
            {
                GameManager.controlador.GanharPontos();
                rig.useGravity = true;

            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Chao"))
        {
            Destroy(this.gameObject);
        }
    }
}
