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
        forceJump = 160f;
        jumping = false;
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

        // Se botão Espaço for apertado e o cubo não estiver pulando(Não estiver em contato com o plano),
        // aplica uma força para o cubo pular
        if (Input.GetKey(KeyCode.Space) && !jumping){
            this.gameObject.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.up * forceJump);
        }

    }
    void OnCollisionEnter(Collision col){
    // Se o cubo estiver em contato com o chão, a variavel pulando se torna falsa
        // plano é a tag adicionada para representar o chão(plano)
        if (col.gameObject.tag == "plano"){
            jumping = false;

            // Apenas mostra essa mensagem no log
            Debug.Log("jumping false");
        }
    }

    void OnCollisionExit(Collision col){
    // Se o cubo não estiver em contato com o chão, a variavel pulando se torna verdadeira
        // plano é a tag adicionada para representar o chão(plano)
        if (col.gameObject.tag == "plano"){
            jumping = true;

            // Apenas mostra essa mensagem no log
            Debug.Log("jumping true");
        }
    }

}
