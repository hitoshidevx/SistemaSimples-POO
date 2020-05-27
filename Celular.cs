namespace SistemaSimplesPOO_Celular
{
    public class celular
    {
        public string color;
        public string model;
        public float size;
        public bool on;
        
        public bool On(string condicao){
            switch(condicao){
                case "sim":
                    on = true;
                break;
                case "nao":
                    on = false;
                break;
                default:
                break;
            }
            return on;
        }


        
    }
}