using FogGerenciadorDeVendas.Dominio.Produtos;
using FogGerenciadorDeVendas.Telas.Controles.Produtos.Helper;
using FogGerenciadorDeVendas.Telas.Helper;
using MetroFramework;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;
using Unity.Resolution;

namespace FogGerenciadorDeVendas.Telas.Controles.Produtos
{
    public partial class Produtos : MetroUserControl
    {
        private readonly IProdutosRepositorio _produtosRepositorio;
        private readonly ListarProdutosServico _listarProdutoService;

        public Produtos(IProdutosRepositorio produtosRepositorio,
            ListarProdutosServico listarProdutoService)
        {
            _produtosRepositorio = produtosRepositorio;
            _listarProdutoService = listarProdutoService;

            InitializeComponent();

            MontarGridProdutos();
            btn_edita_produto.Enabled = false;
            btn_remover_produto.Enabled = false;
        }
        

        public void MontarGridProdutos(string codigoOuNome = "")
        {
            GridProdutosHelper.MontarGridProdutos(produtos_grid, _listarProdutoService.PesquisarPorCodigoOuNome(codigoOuNome));
        }

        private void txt_codigo_nome_KeyUp(object sender, KeyEventArgs e)
        {
            var codigoOuNome = txt_codigo_nome.Text;
            if (codigoOuNome.Length % 3 == 0 || codigoOuNome.Length == 1)
            {
                MontarGridProdutos(codigoOuNome);
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
            AlterarTelaHelper.AlterarTela((MetroPanel)Parent, Program.container.Resolve<Cadastrar>());
        }

        private void btn_edita_produto_Click(object sender, System.EventArgs e)
        {
            if (produtos_grid.SelectedRows.Count == 1)
            {
                var id = (int)produtos_grid.SelectedRows[0].Cells[0].Value;
                var editar = Program.container.Resolve<Editar>();
                AlterarTelaHelper.AlterarTela((MetroPanel)Parent, editar);
                editar.CarregarProduto(id);
            }
        }

        private void btn_remover_produto_Click(object sender, System.EventArgs e)
        {
            var confirmacao = MetroMessageBox.Show(this, 
                "\n\nTem certeza que deseja excluir o produto?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (confirmacao.ToString().ToLower() == "yes")
            {
                var id = (int)produtos_grid.SelectedRows[0].Cells[0].Value;
                _produtosRepositorio.Remover(_produtosRepositorio.ObtemPorId(id));
                MontarGridProdutos();
            }
        }
    }
}
