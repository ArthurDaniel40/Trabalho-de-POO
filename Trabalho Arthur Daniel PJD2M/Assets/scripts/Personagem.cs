public class Personagem
{
    // Variáveis privadas para guardar os dados
    private string nome;
    private int vida;
    private int forca;
    private float velocidade;

    // Propriedades para ler e escrever as variáveis
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

    public int Forca
    {
        get { return forca; }
        set { forca = value; }
    }

    public float Velocidade
    {
        get { return velocidade; }
        set { velocidade = value; }
    }
}
