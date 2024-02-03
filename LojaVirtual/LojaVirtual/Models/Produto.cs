namespace LojaVirtual.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThubnailUrl { get; set; }
        public bool IsProdutoPreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CatedoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
