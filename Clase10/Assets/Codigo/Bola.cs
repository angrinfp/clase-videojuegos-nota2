using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    private Rigidbody2D pelota;
    public Column codigoColumna;

    // Use this for initialization
    void Start()
    {
        pelota = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 fuerzaIzquierda = new Vector2(-10, 0);
            pelota.AddForce(fuerzaIzquierda);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 fuerzaDerecha = new Vector2(10, 0);
            pelota.AddForce(fuerzaDerecha);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 fuerzaArriba = new Vector2(0, 10);
            pelota.AddForce(fuerzaArriba);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 fuerzaAbajo = new Vector2(0, -10);
            pelota.AddForce(fuerzaAbajo);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "columna")
        {
            collision.gameObject.SetActive(true);
            codigoColumna.AumentarPuntajes();
            codigoColumna.RestarPuntajes();
        }
    }
}