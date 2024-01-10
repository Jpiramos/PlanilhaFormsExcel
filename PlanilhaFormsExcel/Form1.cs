using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;






namespace PlanilhaFormsExcel
{
    public partial class Form1 : Form
    {


        Excel.Application app = new Excel.Application();
        Workbook pasta;
        Worksheet plan;
        string path = @"C:\Downloads\resultado.xlsx";



        public Form1()
        {
            InitializeComponent();
            CarregarPlanilha();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            CarregarPlanilha();
        }

        private void CarregarPlanilha()
        {
            lblStatus.Text = "Abrindo planilha de resultado ... ";

            try
            {
                pasta = app.Workbooks.Open(path);
                plan = pasta.Worksheets["Plan1"];

                lblStatus.Text = "Carregando receitas";

                //Receitas 
                txtFaturamento.Text = plan.Cells[5, 3].Value.ToString("N2");
                lblDevolucoes.Text = plan.Cells[6, 3].Value.ToString("N2");
                lblTotalReceitas.Text = plan.Cells[7, 3].Value.ToString("N2");

                lblStatus.Text = "Carregando despesas";

                //Despesas
                lblComissoes.Text = plan.Cells[10, 3].Value.ToString("N2");
                lblCustoDosProdutos.Text = plan.Cells[11, 3].Value.ToString("N2");
                lblImpostos.Text = plan.Cells[12, 3].Value.ToString("N2");
                lblDespesasAdmnistrativas.Text = plan.Cells[13, 3].Value.ToString("N2");
                lblTotalDespesas.Text = plan.Cells[14, 3].Value.ToString("N2");


                lblStatus.Text = "Carregando Resultado";

                //Resultado
                lblResultadoOperacional.Text = Convert.ToDecimal(plan.Cells[16, 3].Value).ToString("N2");

                if (pasta.ReadOnly)
                {
                    txtFaturamento.Enabled = false;
                    btnSalvar.Enabled = false;
                    lblStatus.Text = "Pronto, somente Leitura.";
                }
                else
                {
                    txtFaturamento.Enabled = true;
                    btnSalvar.Enabled = true;
                    txtFaturamento.Focus();
                    lblStatus.Text = "Pronto";

                }


                txtFaturamento.Enabled = true;
            }


            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }



        }


        private void SalvarPlanilha()
        {

            lblStatus.Text = "Salvando a planilha de resultado, aguarde...";

            try
            {

                //Receitas

                plan.Cells[5, 3].Value = Convert.ToDecimal("0" + txtFaturamento.Text);
                pasta.Save();

                MessageBox.Show("Planilha foi Salva");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);

            }

            lblStatus.Text = "Pronto";

        }






        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (pasta != null)

                pasta.Close(true);



            app.Quit();

            plan = null;
            pasta = null;
            app = null;
            lblStatus.Text = "Pronto";



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarPlanilha();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
