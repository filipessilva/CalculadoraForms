using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//fim do construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o primeiro numero

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o segundo numero

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando o primeiro numero
                double num2 = Convert.ToDouble(textBox2.Text);//coletando o segundo numero
                double resultado = model.Somar(num1, num2);//gerar o resultado
                label3.Text = "" + resultado; // escrever o resultado
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados\n\n" + erro);
            }
        }//fim do botao somar

        private void Subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando o primeiro numero
                double num2 = Convert.ToDouble(textBox2.Text);//coletando o segundo numero
                double resultado = model.Subtrair(num1, num2);//gerar o resultado
                label3.Text = "" + resultado; // escrever o resultado
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados\n\n" + erro);
            }
        }//fim do botao subtrair

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {


                double num1 = Convert.ToDouble(textBox1.Text);//coletando o primeiro numero
                double num2 = Convert.ToDouble(textBox2.Text);//coletando o segundo numero
                double resultado = model.Multiplicar(num1, num2);//gerar o resultado
                label3.Text = "" + resultado; // escrever o resultado
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados\n\n" + erro);
            }
        }//fim do botao multiplicar

        private void Divisao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando o primeiro numero
                double num2 = Convert.ToDouble(textBox2.Text);//coletando o segundo numero
                double resultado = model.Dividir(num1, num2);//gerar o resultado

                //validação
                if (resultado == -1)
                {
                    label3.Text = "Impossivel dividir!";
                }
                else
                {
                    label3.Text = "" + resultado; // escrever o resultado
                }
                //fim validação
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados\n\n" + erro);
            }

        }//fim do botao divisao

        private void Raiz_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando o primeiro numero
                double resultado = model.Raiz(num1);//gerar o resultado

                //validação
                if (resultado == -1)
                {
                    label3.Text = "Impossivel calcular a raiz!";
                }
                else
                {
                    label3.Text = "" + resultado; // escrever o resultado
                }
                //fim da validação
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados\n\n" + erro);
            }

        }//fim do botao raiz

        private void Potencializacao_Click(object sender, EventArgs e)
        {
            try
            {
                double bas = Convert.ToDouble(textBox1.Text);//coletando a base
                double expoente = Convert.ToDouble(textBox2.Text);//coletando o expoente
                double resultado = model.Potencia(bas, expoente);//gerar o resultado
                label3.Text = "" + resultado; // escrever o resultado
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados\n\n" + erro);
            }

        }//fim do botao potencializar

        private void label3_Click(object sender, EventArgs e)
        {

        }// fim da label resultado

    }//fim da classe
}//fim do projeto
