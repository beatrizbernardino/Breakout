using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoRaquete : MonoBehaviour
{
    [Range(1, 15)]
    public float velocidade = 5.0f;
    GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();

    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameState != GameManager.GameState.GAME)
        {
            return;
        }

        float inputX = Input.GetAxis("Horizontal");




        // Vector2 posicaoViewport = Camera.main.WorldToViewportPoint(transform.position);

        // if ((posicaoViewport.x < 0.08 || posicaoViewport.x > 0.9) && )
        // {
        //     transform.position = transform.position;
        // }

        // if (posicaoViewport.x < 0.06 && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        // {

        //     transform.position = transform.position;
        // }
        // else if (posicaoViewport.x > 0.94 && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        // {

        //     transform.position = transform.position;
        // }
        // else
        // {
        //     transform.position += new Vector3(inputX, 0, 0) * Time.deltaTime * velocidade;

        // }
        transform.position += new Vector3(inputX, 0, 0) * Time.deltaTime * velocidade;



        if (Input.GetKeyDown(KeyCode.Escape) && gm.gameState == GameManager.GameState.GAME)
        {
            gm.ChangeState(GameManager.GameState.PAUSE);
        }
    }
}
