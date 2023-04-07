using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exer4 : MonoBehaviour
{
    //váriavel de velocidade
    float Speed = 5.0f;
    //Esta Criando uma variável para mover o objeto em direção a um alvo
    public Transform target;
    //Esta armazenando a pontuação do jogador 
    public int score = 0;
    //o maximo que o jogador podera ter de pontuação 
    public int MaxScore = 7;


     void Start()
    {
        //Esta informando para onde o objeto ficara olhando na direção de outro objeto
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        //Esta atribuindo o valor zero para o score
        score = 0;
    }

    //Esta almentando a pontuação, cada vez que o objeto chega a cada ponto
    public void AddScore(int newScore)
    {
        score += newScore;
    }

    void Update()
    {
        //Esta movendo o objeto
        transform.Translate(new Vector3(0,0,Speed * Time.deltaTime));
        //Esta verificando se score é igual MaxScore, se caso for a velocidade do objeto sera 0
        if (score == MaxScore)
        {
            Speed = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Esta verificando se o objeto colidiu com algum outro com a tag Waypoint
        if (other.tag == "Waypoint")
        {
            //Esta indicando para onde o objeto devera ir, depois que colidir com um objeto com tag Waypoint
            target = other.gameObject.GetComponent<Waypoint>().NexPoint;
            //Esta informando para onde o objeto ficara olhando na direção de outro objeto
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
            //Esta Adicionando 1 ponto no score para cada vez que o objeto colide com outro objeto que tenha a teg Waypoint
            AddScore(1);
        }
    }

    
}
