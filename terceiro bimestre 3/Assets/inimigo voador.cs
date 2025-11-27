using UnityEngine;

public class InimigoVoadorPerseguidor : MonoBehaviour
{
    public float velocidade = 4f;
    public float distanciaDeteccao = 6f;

    private Transform jogador;

    void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distancia = Vector2.Distance(transform.position, jogador.position);

        if (distancia < distanciaDeteccao)
        {
            // Voa em direção ao jogador
            transform.position = Vector2.MoveTowards(
                transform.position,
                jogador.position,
                velocidade * Time.deltaTime
            );
        }
    }
}