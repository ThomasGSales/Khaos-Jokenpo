using UnityEngine;

public class AtaqueMovimento : MonoBehaviour
{
    public GameObject efeitoDesaparecerPrefab;

    private Vector3 direction;
    private float velocidade;
    private float distanciaMaxima;
    private Vector3 startPosition;

    public void ConfigurarAtaque(Vector3 dir, float vel, float distancia)
    {
        direction = dir;
        velocidade = vel;
        distanciaMaxima = distancia;
        startPosition = transform.position;

    }

    void Update()
    {
        
        transform.position += direction * velocidade * Time.deltaTime;


        if (Vector3.Distance(startPosition, transform.position) >= distanciaMaxima)
        {
            DestruirComEfeito();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            Debug.Log("Inimigo atingido!");
        }
    }

    void DestruirComEfeito() {
        Instantiate(efeitoDesaparecerPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}
