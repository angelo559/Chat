using System;

public class Facebook : ChannelBase
{
    public Facebook() : base("Facebook") { }

    public override void EnviarMensagem(string usuario, MessageBase message)
    {
        Console.WriteLine($"\n[Facebook] Enviando para o usuário {usuario}...");
        message.ExibirDetalhes();
    }
}
