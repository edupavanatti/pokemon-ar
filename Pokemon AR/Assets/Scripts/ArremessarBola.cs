using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class ArremessarBola : MonoBehaviour
{
    Touch touch;
    public Camera firstPersonCamera;
    private Anchor anchor;
    bool arremessando = false;
    float distancia = 0f;
    public float velocidade = 10f;
    public float velocidadeArremesso = 4f;
    public float velocidadeBola = 4f;

    void OnTouchDrag()
    {
        arremessando = true;
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Rigidbody>().velocity += this.transform.forward * velocidadeArremesso;
        this.GetComponent<Rigidbody>().velocity += this.transform.up * velocidadeBola;
        arremessando = false;
    }

    void Update()
    {
        if (arremessando)
        {
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            Vector3 rayPoint = ray.GetPoint(distancia);
            transform.position = Vector3.Lerp(this.transform.position, rayPoint, velocidade * Time.deltaTime);
        }
    }
}