using UnityEngine;
using UnityEngine;
using UnityEngine.Serialization;

public class Filipe : Personagem
{
    [SerializeField] private string habilidadeEspecial = "Explosão Arcana";
    [FormerlySerializedAs("tipoMagia")] [SerializeField] private string tipoDano = "Magia Caótica";

    public string HabilidadeEspecial
    {
        get { return habilidadeEspecial; }
        set { habilidadeEspecial = value; }
    }

    public string TipoDano
    {
        get { return tipoDano; }
        set { tipoDano = value; }
    }
}
