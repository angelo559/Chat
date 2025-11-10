using System;

public class Telegram : ChannelBase
{
    public Telegram() : base("Telegram") { }

    public override void EnviarMensagem(string usuario, MessageBase message)
    {
        Console.WriteLine($"\n[Telegram] Enviando para o usuário {usuario}...");
        message.ExibirDetalhes();
    }
}
