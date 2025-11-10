// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Envio de Mensagens ===");
        Console.WriteLine("Escolha o canal para enviar a mensagem:");
        Console.WriteLine("1. WhatsApp");
        Console.WriteLine("2. Telegram");
        Console.WriteLine("3. Instagram");
        Console.WriteLine("4. Facebook");
        Console.Write("Opção: ");

        string resposta = Console.ReadLine();
        int canal;

        if (!int.TryParse(resposta, out canal))
        {
            Console.WriteLine("❌ Opção inválida!");
            return;
        }

        Console.WriteLine("\nEscolha o tipo de mensagem:");
        Console.WriteLine("1. Texto");
        Console.WriteLine("2. Vídeo");
        Console.WriteLine("3. Foto");
        Console.WriteLine("4. Arquivo");
        Console.Write("Opção: ");

        string respostaTipo = Console.ReadLine();
        int tipoMensagem;

        if (!int.TryParse(respostaTipo, out tipoMensagem))
        {
            Console.WriteLine("❌ Tipo inválido!");
            return;
        }

        MessageBase mensagem = null;

        // Escolher o tipo de mensagem
        switch (tipoMensagem)
        {
            case 1:
                mensagem = new TextMessage("Olá! Essa é uma mensagem de texto.");
                break;
            case 2:
                mensagem = new VideoMessage("Veja este vídeo!", "video.mp4", 30.5);
                break;
            case 3:
                mensagem = new PhotoMessage("Confira esta foto!", "imagem.png", "PNG");
                break;
            case 4:
                mensagem = new FileMessage("Segue o documento.", "relatorio.pdf", "PDF");
                break;
            default:
                Console.WriteLine("❌ Tipo de mensagem inválido!");
                return;
        }

        ChannelBase canalSelecionado = null;
        string destino = "";

        // Escolher o canal
        switch (canal)
        {
            case 1:
                canalSelecionado = new WhatsApp();
                Console.Write("Informe o número do WhatsApp: ");
                destino = Console.ReadLine();
                break;
            case 2:
                canalSelecionado = new Telegram();
                Console.Write("Informe o usuário do Telegram: ");
                destino = Console.ReadLine();
                break;
            case 3:
                canalSelecionado = new Instagram();
                Console.Write("Informe o usuário do Instagram: ");
                destino = Console.ReadLine();
                break;
            case 4:
                canalSelecionado = new Facebook();
                Console.Write("Informe o usuário do Facebook: ");
                destino = Console.ReadLine();
                break;
            default:
                Console.WriteLine("❌ Canal inválido!");
                return;
        }

        // Enviar mensagem (polimorfismo)
        canalSelecionado.EnviarMensagem(destino, mensagem);

        Console.WriteLine("\n✅ Mensagem enviada com sucesso!");
    }
}
