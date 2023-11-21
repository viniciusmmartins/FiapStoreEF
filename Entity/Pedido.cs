namespace FiapStore.Entity
{
    public class Pedido : Entidade
    {
        public string? NomeProduto { get; set; }
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
