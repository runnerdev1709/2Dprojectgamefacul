using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D Personagem; // var controla o personagem
    public bool moveLeft; // var que controla o personagem para esq.
    public bool moveRight; // var que controla o personagem para dir.
    public float horizontalMove;  // var que move p personagem no eixo
    public float speed = 15; // var de velocidade
    public float jumpSpeed = 5; // var de controle de velocidade de pulo
    private bool isGrounded; // var para reconhecimento do chão
    private bool canDoubleJump; // var que controla pulo duplo
    public float delayBeForeDoubleJump; // var que controla tempo de pulo
    private bool facingRight = true; // var para controlar o sprite do player para dir e esq
    void Start()
    {
        Personagem = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 