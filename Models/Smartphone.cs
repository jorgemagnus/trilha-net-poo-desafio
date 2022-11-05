namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //IMPLEMENTADO!
        private  string Modelo { get; set; }
        private  string IMEI { get; set; }
        private  int Memoria { get; set; }

        public Smartphone()
        {

        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // IMPLEMENTADO!
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void SmartphoneMostrarConfiguracao(string nomeMarcaDispositivo)
        {
            //IMPLEMENTADO!
            Console.WriteLine("Detalhe do Dispositivo: "+ nomeMarcaDispositivo);
            Console.WriteLine("Numero: " +Numero);
            Console.WriteLine("Modelo: " +Modelo);
            Console.WriteLine("IMEI: " +IMEI);
            Console.WriteLine("Memoria: " +Memoria);
        }


        public abstract void InstalarAplicativo(string nomeApp);
    }
}