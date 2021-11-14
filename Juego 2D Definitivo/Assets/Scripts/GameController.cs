using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    static GameController current;

    [SerializeField] private Text contadorMonedas;

    private int monedas;

    public static void ActualizarMonedas()
    {
        current.monedas ++;

        if (current.monedas < 10)
        {
            current.contadorMonedas.text = "0" + current.monedas;
        }
        else
        {
            current.contadorMonedas.text = current.monedas.ToString();
        }
    }

    void Awake()//siemore va a existir y ser el mismo
    {
        if (current != null && current != this)//si tiene un valor y no es este
        {
            Destroy(gameObject);// destruyo y salimos
            return;
        }
        current = this;//asigna valor
        DontDestroyOnLoad(gameObject);//no afecta el cambio de escenas
    }

    // Start is called before the first frame update
    void Start()
    {
        InicioPartida();
    }

    void InicioPartida()
    {
        current.monedas = 0;
        
    }
}
