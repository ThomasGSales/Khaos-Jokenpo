using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicioManager : MonoBehaviour
{

  [SerializeField] private string nomeDoLevelDoJogo;
  [SerializeField] private GameObject painelMenuInicio;

  public void jogar(){
    SceneManager.LoadScene(nomeDoLevelDoJogo);
  }

  public void sair(){
    Debug.Log("Saindo...");
    Application.Quit();
  }
}
