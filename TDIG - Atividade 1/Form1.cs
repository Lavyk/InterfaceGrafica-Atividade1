using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDIG___Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Função Hint no C#
            ToolTip ToolTip1 = new ToolTip();

            ToolTip1.SetToolTip(this.textBox1, "TextBox 1");
            ToolTip1.SetToolTip(this.textBox2, "TextBox 2");
            ToolTip1.SetToolTip(this.textBox3, "TextBox 3");
            ToolTip1.SetToolTip(this.textBox4, "TextBox 4");
            ToolTip1.SetToolTip(this.textBox5, "TextBox 5");

            ToolTip1.SetToolTip(this.button1, "Botão 1");
            ToolTip1.SetToolTip(this.button2, "Botão 2");
            ToolTip1.SetToolTip(this.button3, "Botão 3");
            ToolTip1.SetToolTip(this.button4, "Botão 4");
            ToolTip1.SetToolTip(this.button5, "Botão 5");

            ToolTip1.SetToolTip(this.botaoAtualizar, "Atualizar botões");
        }

        
        private void BotaoAtualizar_Click(object sender, EventArgs e) // Quando clickar no botãoAtualizar
        {
            // Chama a função para atualizar cada botão.
            this.Atualizar(this.textBox1, this.button1);
            this.Atualizar(this.textBox2, this.button2);
            this.Atualizar(this.textBox3, this.button3);
            this.Atualizar(this.textBox4, this.button4);
            this.Atualizar(this.textBox5, this.button5);
        }

        private void Atualizar(TextBox txt, Button btn) //Parametros: respectivos textBox e botão.
        {
            //Verifica se o textBox ta vazio
            String txtTemp; // Variavel temporaria
            if (txt.Text == "") // Se tiver vazio pega o nome normal do botão e salva na variavel temporaria.
            {
                txtTemp = btn.AccessibleName;
            }
            else // Se não estiver vazio, pega o texto do textBox e salva na variavel temporaria.
            {
                txtTemp = txt.Text;
            }
            // Atualiza o texto do botão
            btn.Text = txtTemp;
        }
    }
}
