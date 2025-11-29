using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    public float distanciaDePerseguicao = 10f;

    private Transform player;
    private NavMeshAgent agente;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, player.position);

        // Se o jogador estiver perto, perseguir
        if (distancia <= distanciaDePerseguicao)
        {
            agente.SetDestination(player.position);
        }
        else
        {
            // Para quando o jogador sai do alcance
            agente.ResetPath();
        }
    }
}