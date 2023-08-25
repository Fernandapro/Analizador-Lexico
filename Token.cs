namespace Compiladoresclase
{
    public class Token
    {
        public string str_token;
        public string descripcion;
        public Token(string str_token, string descripcion)
        {
            this.str_token = str_token;
            this.descripcion = descripcion;
        }
        public Token()
        {

        }
    }
}