using System.Threading;

namespace ExemploEvento1
{
    public class Carro
    {
        int qtdTanque = 0;
        public string Telefone { get; set; }
        public Carro(int qtdGasolina, string telefone)
        {
            this.qtdTanque = qtdGasolina;
            this.Telefone = telefone;
        }

        public void Ligar(){

            while(true){
                System.Console.WriteLine("Tanque: " + this.qtdTanque);
                Thread.Sleep(1000);
                this.qtdTanque--;

                if(this.qtdTanque.Equals(0)){
                    this.TanqueVazio();
                    break;
                }
            }
        }

        public delegate void EventoCarro();
        public event EventoCarro TanqueVazio;
    }
}