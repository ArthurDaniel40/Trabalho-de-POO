using UnityEngine;

public class Personagem: MonoBehaviour
{
 
    private string nome;
    private int vida;
    private int _nivel;
    private float velocidade;

  
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public int Nivel
    {
        get { return _nivel; }
        set { _nivel = value; }
    }

    public float Velocidade
    {
        get { return velocidade; }
        set { velocidade = value; }
    }
    public float Mana
    {
        get { return Mana; }
        set { Mana = value; }
    }
}
