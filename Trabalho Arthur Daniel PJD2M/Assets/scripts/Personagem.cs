using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int vida;
    [SerializeField]
    private int _nivel;
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float mana; 

   
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
        get { return mana; }
        set { mana = value; }
    }

 
    public bool CompararNivel(Personagem outro)
    {
        return this.Nivel > outro.Nivel;
    }
}