namespace CSharpEF.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome} | Categoria: {Categoria.ToString()}";
        }
    }
}
