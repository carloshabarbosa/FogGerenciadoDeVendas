using FogGerenciadorDeVendas.Dominio.Produtos;
using FogGerenciadorDeVendas.Telas.Helper;
using MetroFramework.Controls;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace FogGerenciadorDeVendas.Telas.Controles.Produtos
{
    public partial class Produtos : MetroUserControl
    {
        private readonly IProdutosRepositorio _produtosRepositorio;

        public Produtos(IProdutosRepositorio produtosRepositorio)
        {
            _produtosRepositorio = produtosRepositorio;
            InitializeComponent();
            RecuperarProdutos();
            btn_edita_produto.Enabled = false;
            btn_remover_produto.Enabled = false;
        }
        

        public void RecuperarProdutos(string codigoOuNome = "")
        {
            produtos_grid.DataSource = null;
            produtos_grid.DataSource = _produtosRepositorio.PesquisarPorCodigoOuNome(codigoOuNome)
                .Select(c => new
                {
                    Codigo = c.Id,
                    c.Nome,
                    c.Descricao,
                    Valor = string.Format("{0:C}", c.Valor),
                    c.DataDeCadastro
                })
                .ToList();

            produtos_grid.Columns[2].HeaderText = "Descrição";
            produtos_grid.Columns[4].HeaderText = "Data de cadastro";
            produtos_grid.ClearSelection();
        }

        private void txt_codigo_nome_KeyUp(object sender, KeyEventArgs e)
        {
            var codigoOuNome = txt_codigo_nome.Text;
            if (codigoOuNome.Length % 3 == 0 || codigoOuNome.Length == 1)
            {
                RecuperarProdutos(codigoOuNome);
            }
        }

        private void produtos_grid_SelectionChanged(object sender, System.EventArgs e)
        {
            btn_edita_produto.Enabled = false;
            btn_remover_produto.Enabled = false;
            if (produtos_grid.SelectedRows.Count == 1)
            {
                btn_edita_produto.Enabled = true;
                btn_remover_produto.Enabled = true;
            }

            
        }

        private void btn_add_produto_Click(object sender, System.EventArgs e)
        {
            AlterarTelaHelper.AlterarTela((MetroPanel)Parent, Program.container.Resolve<Adicionar>());
        }

        
    }
}
