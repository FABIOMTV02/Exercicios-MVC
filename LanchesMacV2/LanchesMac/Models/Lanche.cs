using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId{ get; set; }
        [Required(ErrorMessage = "Informe o nome do lanche.")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 4, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descricao do lanche deve ser informada.")]
        [Display(Name = "Descricao do Lanche.")]
        [MinLength(10, ErrorMessage = "Descricao deve ter no minimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descricao deve ter no maximo {2} caracteres.")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descricao detalhada do lanche deve ser informada.")]
        [Display(Name = "Descricao do Lanche.")]
        [MinLength(20, ErrorMessage = "Descricao deve ter no minimo {1} caracteres.")]
        [MaxLength(300, ErrorMessage = "Descricao deve ter no maximo {2} caracteres.")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preco do lanche.")]
        [Display(Name = "Preco")]
        [Column(TypeName = "decimal(10,2")]
        [Range(1,999.99,ErrorMessage ="O preco deve ser entre 1 a 999,99.")]
        public decimal Preco { get; set; }
        [Display(Name ="Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres.")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200,ErrorMessage ="O {0} deve ter no maximo {1} caracteres.")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido  { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
