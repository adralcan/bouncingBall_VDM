using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

    public GameObject bolaPrefab;
    GameObject sprite;
    public int fuerza = 5;

    int contBolas;

	// Use this for initialization
	void Start () {
        //Leer nivel, este nos dice las bolas (?) o es el archivo de guardado?
        contBolas = 5;		
	}


    Vector2 direccion;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Version PC
        if (Input.GetMouseButton(0))
        {
            Debug.Log("click");
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Debug.Log(mousePosition);
            Debug.DrawLine(transform.position, (transform.position + mousePosition) * 10, Color.red, Mathf.Infinity);

            //Vector2 direccion = Vector2.d (mousePosition, transform.position)
            direccion = mousePosition - transform.position;
            direccion = direccion.normalized;

            for (int i = 0; i < contBolas; i++)
            {
                Invoke("Disparar", 0.5f);                    //CORRUTINAS
                
                //Screen.height;
            }
            //cont = 0;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
        }
    }

    void Disparar()
    {
        GameObject aux = Instantiate(bolaPrefab);
        //Nos aseguramos z = 0
        aux.transform.position = new Vector3(aux.transform.position.x, aux.transform.position.y, 0);
        //aux.GetComponent<Rigidbody2D>().AddForce(direccion * fuerza * Time.deltaTime);
        aux.GetComponent<Rigidbody2D>().velocity = direccion * fuerza * Time.deltaTime;
    }


}
