using System;

public class VideoMessage : MessageBase
{
    public string Arquivo { get; set; }
    public double Duracao { get; set; }

    public VideoMessage(string mensagem, string arquivo, double duracao) : base(mensagem)
    {
        Arquivo = arquivo;
        Duracao = duracao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[Vídeo] Mensagem: {Mensagem} | Arquivo: {Arquivo} | Duração: {Duracao}s | Enviado em: {DataEnvio}");
    }
}
