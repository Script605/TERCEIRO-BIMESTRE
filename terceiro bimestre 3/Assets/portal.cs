using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [Header("Nome da cena para carregar")]
    public string nomeDaCena;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto que entrou é o jogador
        if (collision.CompareTag("Player"))
        {
            CarregarProximaCena();
        }
    }

    void CarregarProximaCena()
    {
        if (!string.IsNullOrEmpty(nomeDaCena))
        {
            SceneManager.LoadScene(nomeDaCena);
        }
        else
        {
            Debug.LogError("Nenhuma cena definida no portal!");
        }
    }
}
