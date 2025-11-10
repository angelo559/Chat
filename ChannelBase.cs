using System;

public abstract class ChannelBase
{
    public string NomeCanal { get; set; }

    public ChannelBase(string nome)
    {
        NomeCanal = nome;
    }

    public abstract void EnviarMensagem(string destino, MessageBase message);
}
