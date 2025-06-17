using UnityEngine;

public class DanoAoColidir : MonoBehaviour
{
    public int dano = 10;

    private void OnCollisionEnter(Collision collision)
    {
   
        Personagem personagem = collision.gameObject.GetComponent<Personagem>();

        if (personagem != null)
        {
            personagem.Vida -= dano;

          
            Debug.Log($"O jogador {personagem.Nome} colidiu com '{gameObject.name}' e perdeu {dano} de vida. Vida atual: {personagem.Vida}");

         
            if (personagem.Vida <= 0)
            {
                Debug.Log($"{personagem.Nome} morreu após a colisão.");
            }
        }
    }
}