using System;
using MetroFramework.Controls;
using System.Globalization;
using System.Text.RegularExpressions;
using Unity;
using FogGerenciadorDeVendas.Telas.Helper;
using FogGerenciadorDeVendas.Dominio.Produtos;
using MetroFramework;
using System.Windows.Forms;

namespace FogGerenciadorDeVendas.Telas.Controles.Produtos
{
    public partial class Editar : MetroUserControl
    {
        private readonly IProdutosRepositorio _produtoRepositorio;
        private readonly Produtos _telaProdutos;
        public int _produtoId;
        private Produto produtoEditar;
        public Editar(IProdutosRepositorio produtoRepositorio, Produtos telaProdutos)
        {
            _produtoRepositorio = produtoRepositorio;
            InitializeComponent();
            _telaProdutos = telaProdutos;
        }

        public void CarregarProduto(int produtoId)
        {
            produtoEditar = _produtoRepositorio.ObtemPorId(produtoId);
            if (produtoEditar != null)
            {
                txt_nome.Text = produtoEditar.Nome;
                txt_valor.Text = produtoEditar.Valor.ToString();
                txt_descricao.Text = produtoEditar.Descricao;
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txt_valor.Text.Replace(",", ".")
                .Replace("R$", "");
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txt_valor.TextChanged -= metroTextBox2_TextChanged;
                //Format the text as currency
                txt_valor.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
                txt_valor.TextChanged += metroTextBox2_TextChanged;
                txt_valor.Select(txt_valor.Text.Length, 0);
            }
            else
            {
                txt_valor.Text = "R$ 0,00";
            }
            bool goodToGo = TextisValid(txt_valor.Text);

            if (!goodToGo)
            {
                txt_valor.Text = txt_valor.Text.Substring(0, txt_valor.Text.Length - 1);
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^R\$\D(\d{1,3}(\,\d{1,3})*|(d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AlterarTelaHelper.AlterarTela((MetroPanel)Parent, _telaProdutos);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_valor.Text.Replace("R$ ", ""), out var valor))
            {
                MetroMessageBox.Show(this, "\n\nCampos obrigatórios não preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                produtoEditar.AlterarNome(txt_nome.Text);
                produtoEditar.AlterarDescricacao(txt_descricao.Text);
                produtoEditar.AlterarValor(valor);
                if (!produtoEditar.Validar())
                {
                    MetroMessageBox.Show(this, "\n\nCampos obrigatórios não preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _produtoRepositorio.Salvar();
                        AlterarTelaHelper.AlterarTela((MetroPanel)Parent, Program.container.Resolve<Produtos>());
                    } 
                    catch (Exception ex)
                    {
                        //mostrar erro genério
                    }
                    
                }
            }

        }

    }
}
