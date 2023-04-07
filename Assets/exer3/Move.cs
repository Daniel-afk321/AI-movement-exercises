using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //váriavel de velocidade
    public float Speed = 5.0f;
    //váriavel para ver a força que o objeto tera para pular
    public float jumpForce = 5.0f;
    //Esta indicando que o objeto está no chão
    public bool isOnGround = true;
    //Esta representando o eixo horizontal
    private float horizontalInput;
    //Esta representando o eixo vertical
    private float forwardInput;
    //Esta deixando RB como se fosse a palavra Rigidbody
    private Rigidbody RB;
    


    void Start()
    {
        //Esta Pegando o rigidbody que esta no objeto
        RB = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        //Esta obtendo a entrada do jogador
        horizontalInput = Input.GetAxis("Horizontal");
       forwardInput = Input.GetAxis("Vertical");

        //Esta movendo o jogador
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * Speed * horizontalInput);

        //Esta fazendo que o jogador pule, e esta verificando se o jogador podra ou nao pular
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    //Esta verificando se o player esta em algum objeto com a tag "Ground" para poder pular 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
