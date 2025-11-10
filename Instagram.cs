using System;

public class Instagram : ChannelBase
{
    public Instagram() : base("Instagram") { }

    public override void EnviarMensagem(string usuario, MessageBase message)
    {
        Console.WriteLine($"\n[Instagram] Enviando para o usuário {usuario}...");
        message.ExibirDetalhes();
    }
}
