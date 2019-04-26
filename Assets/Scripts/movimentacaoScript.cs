using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoScript : MonoBehaviour{
    //Criando variaveis para representarem a velocidade de movimento, rotação e força do pulo
    public float movementSpeed;
    public float rotacionSpeed;
    public float forceJump;
    //Variavel booleana para representar se o cubo está no ar ou não
    bool jumping;

    // Função inicial, chamada assim que o jogo é rodado, antes da primeira atualização de quadro
    void Start(){
        // Setando os valores para as variaveis que faram parte do cubo assim que o jogo se inicia
        movementSpeed = 0.15f;
        rotacionSpeed = 3.0f;
    }

    // função de atualização, é chamada uma vez por quadro
    void Update(){

        // Se o botão [seta para Cima] for apertado, mover o cubo para frente
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, 0, movementSpeed);
        }

        // Se o botão [seta para Baixo] for apertado, mover o cubo para tras
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, 0, -movementSpeed);
        }

        // Se o botão [seta para Esquerda] for apertado, girar o cubo em sentido anti horario
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0, rotacionSpeed, 0);
        }

        // Se o botão [seta para Direita] for apertado, girar o cubo em sentido horario     
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0, -rotacionSpeed, 0);
        }

       
    }

   
}
