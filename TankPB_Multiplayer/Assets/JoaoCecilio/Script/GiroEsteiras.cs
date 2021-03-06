using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroEsteiras : MonoBehaviour
{
    // Scroll main texture based on time

    public float scrollSpeed;
    MeshRenderer rend;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0f, offset));
    }
}
