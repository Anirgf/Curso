namespace Entidades.Sistema
{
    public class ComboBoxItemUruario
    {
        public string Login { get; set; }
        public int Codigo { get; set; }
        public string Senha { get; set; }

        public ComboBoxItemUruario(string login, int codigo, string senha)
        {
            Login = login;
            Codigo = codigo;
            Senha = senha;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}
