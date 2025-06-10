using UnityEngine;

public class Arthur : Personagem
{
    [SerializeField] private string HabilidadeEspecial = "Bola de fogo";
    [SerializeField] private string TipoDeDano = "Queimadura";

    public string habilidadeEspecial
    {
        get {return HabilidadeEspecial;}
        set {HabilidadeEspecial = value;}
    }

    public string TipoDeDano
    {
        get {return TipoDeDano}
        
    }
}
