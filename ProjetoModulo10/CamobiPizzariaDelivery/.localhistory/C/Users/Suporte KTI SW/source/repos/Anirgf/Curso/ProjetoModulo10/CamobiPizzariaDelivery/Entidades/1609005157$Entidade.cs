namespace Entidades
{
    public class Entidade : IEntidade
    {
        public int Codigo { get ; set ; }
        public string Descricao { get ; set ; }

        public Entidade(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
