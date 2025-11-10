using System;

public class FileMessage : MessageBase
{
    public string Arquivo { get; set; }
    public string Formato { get; set; }

    public FileMessage(string mensagem, string arquivo, string formato) : base(mensagem)
    {
        Arquivo = arquivo;
        Formato = formato;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[Arquivo] Mensagem: {Mensagem} | Arquivo: {Arquivo} | Formato: {Formato} | Enviado em: {DataEnvio}");
    }
}