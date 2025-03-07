namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        #region ------------- Variaveis -----------------
        private double numero1, numero2;
        private String operacao;

        private Boolean PressionouIgual;

        private double resultado;

        #endregion

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
            PressionouIgual = false;
            resultado = 0;

        }

        private void AdicaoCaracterNumerico(String caracter)
        {

            if (PressionouIgual == true)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
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
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".",","));
                }
                else
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                
                operacao = caracter;
                txtDisplay.Clear();

            }
            else
            {
                MessageBox.Show("Insira algum valor");
            }
        }


        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Divisao por zero!");
                        break;
                    }

                    resultado = numero1 / numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "^":
                    resultado = CalcularPotencia(numero1,numero2);
                    break;

            }
            txtDisplay.Text = resultado.ToString().Replace(",",".");
        }

        private Double CalcularPotencia(Double valorBase, Double valorExpoente)
        {
            return Math.Pow(valorBase, valorExpoente);
            
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
            if (PressionouIgual)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
                return;

            }
            if (txtDisplay.Text.Trim().Equals(String.Empty)) txtDisplay.Text = "0.";
            if (txtDisplay.Text.Trim().Contains(".")) return;
            txtDisplay.Text += ".";
            PressionouIgual = false;
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (operacao.Equals(String.Empty)|| PressionouIgual)
            {
                LimparCampos();
            }
            else
            {
                txtDisplay.Clear();
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {

            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text.Trim().Replace(".",",")) * (-1)).ToString().Replace(",",".");
            }

        }

        private void btnRemoveUltimoDigito_Click(object sender, EventArgs e)
        {

            int tam = txtDisplay.Text.Trim().Length;
            String texto = txtDisplay.Text.Trim();
            txtDisplay.Clear();
            for (int i = 0; i < tam - 1; i++)
            {
                txtDisplay.Text = txtDisplay.Text + texto[i];
            }

        }

        private void btnElevaQuadrado_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {

                numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".",","));
                numero2 = 2;
                var result = CalcularPotencia(numero1,numero2);
                txtDisplay.Text = result.ToString().Replace(",", ".");
                PressionouIgual = true;

            }
        }

        private void btnPotencial_Click(object sender, EventArgs e)
        {
            AdiconarCaracterOperacao("^");
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(",","."));
                resultado = Math.Sqrt(numero1);
                txtDisplay.Text = resultado.ToString().Replace(",", ".");
                PressionouIgual=true;
            }
            
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(",", "."));
                if (numero1 == 0)
                {
                    MessageBox.Show("Erro divis�o por zero");
                    return;
                }    
                resultado = 1 / numero1;
                txtDisplay.Text = resultado.ToString().Replace(",", ".");
                PressionouIgual = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                if (!txtDisplay.Text.Trim().Equals(String.Empty))
                {


                    Calcular();
                    PressionouIgual = true;

                }
            }
        }


    }
}