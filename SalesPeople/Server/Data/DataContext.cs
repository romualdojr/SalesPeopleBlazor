using Microsoft.EntityFrameworkCore;

namespace SalesPeople.Server.Data
{
    public class DataContext : DbContext
    {
        private static readonly List<Product> SeedProducts = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "Série da Fundação",
            Description = "A Série da Fundação é uma obra de ficção científica escrita por Isaac Asimov que descreve em detalhes a história de um futuro distante e de como o destino de seus habitantes é influenciado por uma instituição chamada Fundação Enciclopédica",
            Price = 9.99m,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Fundacaobox_frente_alta.jpg/800px-Fundacaobox_frente_alta.jpg"
        },

        new Product
        {
            Id = 2,
            Title = "Os Contos de Beedle, o Bardo",
            Description = "Os Contos de Beedle, o Bardo é um livro de histórias infantis escrito pela autora J. K. Rowling. Ele é o mesmo livro de contos mencionado em Harry Potter e as Relíquias da Morte, o último livro da série Harry Potter.[2]",
            Price = 5.99m,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/c/c8/Os_Contos_de_Beedle_o_Bardo.jpg"
        },

        new Product
        {
            Id = 3,
            Title = "Necronomicon",
            Description = "O Necronomicon (O Necronomicon é um livro fictício criado por H.P.Lovecraft, autor americano de ficção científica, horror e literatura fantástica. Segundo o próprio, o Necronomicon teria sido escrito em Damasco por volta de 730 d.C. por Abdul Alhazred, um poeta árabe louco originário de Sanaa, no Iémen.",
            Price = 6.66m,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0c/Necronomicon_prop.jpg"
        }};
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(SeedProducts);
        }
    }
}
