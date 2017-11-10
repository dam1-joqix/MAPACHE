using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float fuerzaSalto = 100f;
    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    float comprobadorRadio = 0.07f;
    public LayerMask mascaraSuelo;
    private bool dobleSalto = false;
    private Animator animator;

    private bool corriendo = false;
    public float velocidad = 8f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Use this for initialization
    /**
     * Al empezar el juego
     * */
    void Start()
    {

    }
    /**
     * A cada actualizacion de fisicas
     * comprueba si el personaje esta tocando suelo y si eso ocurre pone doble salto a 0
     * */
    void FixedUpdate()
    {
        if (corriendo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
        }
        animator.SetFloat("velx", GetComponent<Rigidbody2D>().velocity.x);
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animator.SetBool("tocaSuelo", enSuelo);
        if (enSuelo)
        {
            dobleSalto = false;
        }
    }

    // Update is called once per frame
    /**
     * Una vez por fotograma
     * si se hace click o toca la pantalla
     * si esta en el suelo o no ha saltado dos veces salta
     * si no esta en el suelo y salta el dobleSalto se pone a true 
     * para que no lo vuelva a hacer hasta que toque suelo
     * */
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (corriendo)
            {
                //si esta corriendo
                if (enSuelo || !dobleSalto)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaSalto);
                    //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaSalto));
                    //rigidbody2D.AddForze(new Vector2(0, fuerzaSalto));
                    if (!dobleSalto && !enSuelo)
                    {
                        dobleSalto = true;
                    }

                }
            }
            else
            {
                //no esta corriendo
                corriendo = true;
            }
        }
    }
}
