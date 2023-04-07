using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exer2 : MonoBehaviour
{
    //váriavel de velocidade
    public float speed = 2.0f;
    //Esta Criando variável de precisão
    public float accuracy = 0.1f;
    //Esta criando uma variável do tipo transform, e esta indicando o lugar para onde ele deverá ir
    public Transform goal;

    void Start()
    {
        
    }


    void Update()
    {
        //Esta Informando para onde o objeto ira fica olhando
        this.transform.LookAt(goal.position);
        //Esta criando um vector 3 de direção
        Vector3 direction = goal.position - this.transform.position;
        //Esta mostrando uma linha vermelha para uma posição especifica
        Debug.DrawRay(this.transform.position, direction, Color.red);
        //Esta verifica se direction é maior que accuracy
        if (direction.magnitude > accuracy)
        // Esta movendo o objeto para uma direcao
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
