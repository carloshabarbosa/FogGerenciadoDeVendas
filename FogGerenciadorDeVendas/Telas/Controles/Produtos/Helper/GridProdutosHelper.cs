using FogGerenciadorDeVendas.Dominio.Produtos.Dto;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Telas.Controles.Produtos.Helper
{
    public class GridProdutosHelper
    {
        public static void MontarGridProdutos(MetroGrid gridProdutos, List<ListarProdutoDto> dataList)
        {
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = dataList;

            gridProdutos.Columns[2].HeaderText = "Descrição";
            gridProdutos.Columns[3].HeaderText = "Valor";
            gridProdutos.Columns[4].Visible = false;
            gridProdutos.Columns[5].HeaderText = "Data de cadastro";
            gridProdutos.ClearSelection();
        }

        public static void MontarGridProdutosReduzida(MetroGrid gridProdutos, List<ListarProdutoDto> dataList)
        {
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = dataList;

            gridProdutos.Columns[4].Visible = false;
            gridProdutos.Columns[2].HeaderText = "Descrição";
            gridProdutos.Columns[3].HeaderText = "Valor";
            gridProdutos.Columns[5].HeaderText = "Dt. Cadastro";

            gridProdutos.ClearSelection();
        }

        public static void MontarGridProdutosNomeEDescricao(MetroGrid gridProdutos, List<ListarProdutoDto> dataList)
        {
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = dataList;

            gridProdutos.Columns[0].Visible = false;
            gridProdutos.Columns[3].Visible = false;
            gridProdutos.Columns[5].Visible = false;
            gridProdutos.Columns[4].Visible = false;
            gridProdutos.Columns[2].HeaderText = "Descrição";

        }


    }
}
