using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class F_Principal : Form
    {


        List<double> Proventos = new List<double>();
        List<double> Desconto = new List<double>();
        Impostos impostos = new Impostos();




        public F_Principal()
        {
            InitializeComponent();





        }

        private void rd_desconto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txt_adcionar.Text == "")
            {

                MessageBox.Show("Digite um valor valido");
            }

            else
            {

                if (rd_proventos.Checked)
                {


                    try
                    {

                        Proventos.Add(double.Parse(txt_adcionar.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERRO: Digite apenas numeros e virgula (#####,##)");

                    }
                    finally
                    {


                        listBox1.DataSource = null;
                        listBox1.DataSource = Proventos;
                        impostos.VLProventos(Proventos.Sum());
                        txt_TotalProventos.Text = Convert.ToString(Proventos.Sum().ToString("C2"));
                        txt_adcionar.Clear();
                        txt_adcionar.Focus();
                    }






                }
                else

                {

                    try
                    {

                        Desconto.Add(double.Parse(txt_adcionar.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERRO: Digite apenas numeros e virgula (#####,##)");

                    }
                    finally
                    {



                        listBox1.DataSource = null;
                        listBox1.DataSource = Desconto;
                        impostos.VLDesconto(Desconto.Sum());
                        txt_TotalDesconto.Text = Convert.ToString(Desconto.Sum().ToString("C2"));
                        txt_adcionar.Clear();
                        txt_adcionar.Focus();
                    }



                }
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rd_proventos.Checked)

            {
                listBox1.DataSource = null;
                listBox1.DataSource = Desconto;
                txt_adcionar.Clear();
                txt_adcionar.Focus();

            }




            else
            {
                listBox1.DataSource = null;
                listBox1.DataSource = Proventos;
                txt_adcionar.Clear();
                txt_adcionar.Focus();


            }
        }

        private void rd_proventos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if (rd_proventos.Checked)


            {
                try
                {

                    Proventos.RemoveAt(listBox1.SelectedIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERRO:Não há valor a ser removido");

                }
                finally
                {
                    listBox1.DataSource = null;
                    listBox1.DataSource = Proventos;
                    txt_TotalProventos.Text = Convert.ToString(Proventos.Sum().ToString("C2"));
                    txt_adcionar.Clear();
                    txt_TotalProventos.Clear();
                    txt_adcionar.Focus();
                }



            }

            else
            {

                try
                {

                    Desconto.RemoveAt(listBox1.SelectedIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERRO:Não há valor a ser removido");

                }
                finally
                {
                    listBox1.DataSource = null;
                    listBox1.DataSource = Desconto;
                    txt_TotalDesconto.Text = Convert.ToString(Desconto.Sum().ToString("C2"));
                    txt_adcionar.Clear();
                    txt_TotalDesconto.Clear();
                    txt_adcionar.Focus();

                }



            }



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_adcionar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // atribuindo valor a variavvel QtdDependete

            impostos.QtdDependente(double.Parse(comboBox1.Text));

        }

        private void Btn_CalcInss_Click(object sender, EventArgs e)
        {

            //calculo Base e Imposto Inss
            impostos.VLDesconto(Desconto.Sum());
            impostos.VLProventos(Proventos.Sum());
            impostos.VLBaseInss();

            if (impostos.ValorBaseInss < 0)
            {
                MessageBox.Show(" Base Valor Negativo ==> FAVOR VERIFIQUE A DIGITAÇÃO");
            }

            impostos.VLInss();
            Lb__ValorBaseInssForm.Text = impostos.ValorBaseInss.ToString("C2", NumberFormatInfo.CurrentInfo);
            lb_valorInssForm.Text = impostos.ValorInss.ToString("C2", NumberFormatInfo.CurrentInfo);

            //Preenchendo ListView
            ListViewItem item1 = new ListViewItem("7.5 %");

            item1.SubItems.Add("R$ 0,00");
            item1.SubItems.Add("R$1.100,00");
            item1.SubItems.Add(impostos.ValorFaixa7_5.ToString("C2", NumberFormatInfo.CurrentInfo));
            item1.SubItems.Add(impostos.faixa1.ToString("C2", NumberFormatInfo.CurrentInfo));


            ListViewItem item2 = new ListViewItem("9%");
            item2.SubItems.Add("R$1.100,01");
            item2.SubItems.Add("R$2.203,48");
            item2.SubItems.Add(impostos.ValorFaixa9.ToString("C2", NumberFormatInfo.CurrentInfo));
            item2.SubItems.Add(impostos.faixa2.ToString("C2", NumberFormatInfo.CurrentInfo));

            ListViewItem item3 = new ListViewItem("12 %");
            item3.SubItems.Add("R$2.203,49");
            item3.SubItems.Add("R$3.305.22");
            item3.SubItems.Add(impostos.ValorFaixa12.ToString("C2", NumberFormatInfo.CurrentInfo));
            item3.SubItems.Add(impostos.faixa3.ToString("C2", NumberFormatInfo.CurrentInfo));


            ListViewItem item4 = new ListViewItem("14 %");
            item4.SubItems.Add("R$3.305.22");
            item4.SubItems.Add("R$6.433.57");
            item4.SubItems.Add(impostos.ValorFaixa14.ToString("C2", NumberFormatInfo.CurrentInfo));
            item4.SubItems.Add(impostos.faixa4.ToString("C2", NumberFormatInfo.CurrentInfo));


            //Limpando List para não duplicar ao clicar duas vezes
            ListV_Inss.Items.Clear();


            //adicionando dados ao ListV
            ListV_Inss.Items.Add(item1);
            ListV_Inss.Items.Add(item2);
            ListV_Inss.Items.Add(item3);
            ListV_Inss.Items.Add(item4);








        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
