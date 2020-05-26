namespace SistemaSimplesPOO_Celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public string ligacao;
        public string mensagem;
        public bool estado;

        public bool EstadoCelular(string condicao){
            if(condicao == "sim"){
                estado = true;
            }else{
                estado = false;
            }
            return estado;
        }
        }
        }
