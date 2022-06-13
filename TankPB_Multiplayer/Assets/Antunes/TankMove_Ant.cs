using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    //[SerializeField]
   
    //  private int velMov = 1;
    public GameObject tBase;
    public GameObject torreta;
    public GameObject esteiraDir;
    public GameObject esteiraEsq;

    //TankBase
    public float moverVel;
    public float rotateVel;
    //Esteira
    public float textureVel; 
    Renderer rend;
    //Torreta
    public float rotateTorretaVel;
    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            
            transform.Translate(new Vector3(+moverVel, 0, 0));
            float offset = Time.deltaTime * textureVel;
            rend.material.mainTextureOffset = new Vector2(offset, 0);
            rend.material.mainTextureOffset = new Vector2(offset, 0);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(new Vector3(0, -rotateVel, 0));
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, +rotateVel, 0));
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(-moverVel, 0, 0));

        }


        

    }
}
