using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exer1 : MonoBehaviour
{

    //váriavel de velocidade
    public float speed = 2.0f;
    //Esta criando uma variável do tipo transform, e esta indicando o lugar para onde ele deverá ir
    public Transform goal;

    void Start()
    {
        
    }

   
    void Update()
    {
        //Esta criando um vector 3 de direção
        Vector3 direction = goal.position - this.transform.position;
        // Esta movendo o objeto para uma direcao
        this.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
