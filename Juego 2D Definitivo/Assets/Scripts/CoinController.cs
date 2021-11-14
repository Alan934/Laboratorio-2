using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private ParticleSystem particulas;
    private SpriteRenderer spr;//acceder esprite moneda
    private bool activa = true;

    private void Awake()//agarrar componendtes
    {
        particulas = GetComponent<ParticleSystem>();
        spr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && activa)
        {
            GameController.ActualizarMonedas();
            spr.enabled = false;
            particulas.Play();
            activa = false;
            Destroy(gameObject);
        }
    }
}
