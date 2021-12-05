namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private double numero1, numero2;
        private String operacao;

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparCampos();
            txtDisplay.MaxLength = 10;
        }

        #region------------------------------FUNCOES---------------------------

        private void LimparCampos()
        {
            txtDisplay.Clear();
            numero1 = 0;
            numero2 = 0;   
            operacao = String.Empty;

        }

        private void AdicaoCaracterNumerico(String caracter)
        {
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = caracter;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + caracter;
            }
        }

        private void AdiconarCaracterOperacao(String caracter)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                operacao = caracter;
                txtDisplay.Clear();
            }
        }


        private void Calcular()
        {
            switch(operacao)
            {
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Divisao por zero!");
                        break;
                    }
                    
                    txtDisplay.Text = (numero1 / numero2).ToString();
                    break;
                
                case "*":
                    txtDisplay.Text = (numero1 * numero2).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (numero1 - numero2).ToString();
                    break;

                case "+":
                    txtDisplay.Text = (numero1 + numero2).ToString();
                    break;

                    
            }
        }
        #endregion



        #region ----------- Botoes Numericos --------

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicaoCaracterNumerico("9");
        }
        #endregion


        #region --------- Botoes Operacoes --------
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            AdiconarCaracterOperacao("/");
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            AdiconarCaracterOperacao("*");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AdiconarCaracterOperacao("-");
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            AdiconarCaracterOperacao("+");
        }
        #endregion
        private void btnPonto_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                
                numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                
                
            }
        }

       
    }
}