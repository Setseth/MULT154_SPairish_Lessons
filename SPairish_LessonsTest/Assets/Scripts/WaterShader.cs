using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShader : MonoBehaviour
{
    private Renderer rend;
    public Color setColor = Color.yellow;
    public Color setColor2 = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.SetColor("WHColor", setColor);
        rend.material.SetColor("_Shimmer_Color", setColor2);
    }
}
