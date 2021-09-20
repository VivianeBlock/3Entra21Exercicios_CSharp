using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiRetorno
{
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        public void AtualizaDG()
        {
            List<string[]> lista = Function.GenericSelectAll("Historico");
            dgHistorico.Rows.Clear();
            foreach (var item in lista)
            {
                dgHistorico.Rows.Add(item);
            }
           
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }





        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double valorLiquido = 0, novoSaldo = 0, despesas = 0, ganhos = 0;
            bool lucrou = true;



            double valor = Convert.ToDouble(dgHistorico.Rows[dgHistorico.Rows.Count - 1].Cells[1].Value);



            despesas = Convert.ToDouble(textDespesas.Text);
            ganhos = Convert.ToDouble(textGanhos.Text);
            //System.GTlobalization.TextInfo
            CalculaMes(valor, despesas, ganhos, out valorLiquido, out novoSaldo, out lucrou);

            string insert = $"INSERT into dbo.Historico (ValorEmCaixa, DespesasDoMes, GanhosDoMes, ValorLiquido, SeLucrou) values ({novoSaldo.ToString(CultureInfo.InvariantCulture)}, {despesas.ToString(CultureInfo.InvariantCulture)}, {ganhos.ToString(CultureInfo.InvariantCulture)}, {valorLiquido.ToString(CultureInfo.InvariantCulture)}, {Convert.ToInt32(lucrou)})";



            Function.GenericExecute(insert);
            AtualizaDG();



        }

        //        private void btnCalcula_Click(object sender, EventArgs e)
        //        {
        /////////////// CONTINUAR A PARTIR DESTE PONTO AULA: 18/08/2021  03:31:51
        //            double valor = Convert.ToDouble(dgHistorico.Rows[dgHistorico.Rows.Count - 1].Cells[1].Value);

        //            //variaveis para parametro de saida:
        //            double valorLiquido = 0, novoSaldo = 0;
        //            bool lucrou = true;

        //            //variaveis para paramentros de enttrada:

        //            double despesas = 0, ganhos = 0;
        //            despesas = Convert.ToDouble(textDespesas.Text);
        //            ganhos = Convert.ToDouble(textGanhos.Text);

        //            CalculaMes(valor,despesas, ganhos, out valorLiquido, out novoSaldo, out lucrou);
        //  ///////// -> ->          System.Globalization.TextInfo
        //            string insert = $"INSERT into dbo.Historico(ValçorEmCaixa, DespesasDoMes,GanhosDoMes,ValorLiquido,SeLucrou) values ({novoSaldo},{despesas.ToString(CultureInfo.InvariantCulture)},{ganhos.ToString(CultureInfo.InvariantCulture)},{valorLiquido.ToString(CultureInfo.InvariantCulture)}, {Convert.ToInt32(lucrou)} )"; //faz essa conversão para valores em double
        //            Function.GenericExecute(insert);
        //            AtualizaDG();


        //        }


        private void CalculaMes(double saldoAtual, double despesas, double ganhos, out double valorLiquido, out double novoSaldo, out bool deuLucro)
        {

            valorLiquido = ganhos - despesas;
            novoSaldo = saldoAtual + valorLiquido;

            if (valorLiquido > 0)
            {
                deuLucro = true;
            }
            else
            {
                deuLucro = false;
            }

        }

    }
}
