using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCarregarCena : MonoBehaviour
{
    [Header("Nome da cena para carregar")]
    public string nomeDaCena;

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            CarregarCena();
        }
    }

    void CarregarCena()
    {
        if (!string.IsNullOrEmpty(nomeDaCena))
        {
            SceneManager.LoadScene(nomeDaCena);
        }
        else
        {
            Debug.LogError("Nenhum nome de cena foi definido no portal!");
        }
    }
}