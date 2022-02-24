using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_scroll : MonoBehaviour
{
    // Start is called before the first frame update

    private float velocidade = 0.1f;
    private float offset;
    private Material mat;

    void Start()
    {

        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

        offset += (Time.deltaTime) * velocidade / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));

    }
}
