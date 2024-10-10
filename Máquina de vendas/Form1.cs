using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Máquina_de_vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Torna o fundo das etiquetas transparente e define o Parent container para as labels
            lblCafé.Parent = pictureBox1;
            lblCha.Parent = pictureBox1;
            lblChocolate.Parent = pictureBox1;
            lblCappuccino.Parent = pictureBox1;
            lblCafé.BackColor = Color.Transparent;
            lblCha.BackColor = Color.Transparent;
            lblCappuccino.BackColor = Color.Transparent;
            lblChocolate.BackColor = Color.Transparent;
            lbl.Parent = pictureBox1;
            lbl.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;
            label10.BackColor = Color.Transparent;           
            flowLayoutPanel1.Parent = pictureBox1;
            flowLayoutPanel1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;           
            lblTotal.Parent = pictureBox1;
            lblTotal.BackColor = Color.Transparent;
            lblMontante.Parent = pictureBox1;
            lblMontante.BackColor = Color.Transparent;
           
        }
        // Declaração de variáveis
        decimal total = 0;
        decimal montanteInserido = 0;
        decimal troco = 0.00m;
        int contadorCafé = 0;
        int contadorChocolate = 0;
        int contadorCappuccino = 0;
        int contadorCha = 0;
        const int moedasIniciais = 20;
        const int limiteMaximoMoedas = 40;

        //Array das moedas. Tem um valor inicial de 20 moedas para cada moedeiro.
        //Começa da menor para a maior (0.05, 0.10 etc...2.00 euros)
        int[] moedeiro = new int[6] { moedasIniciais, moedasIniciais, moedasIniciais, moedasIniciais, moedasIniciais, moedasIniciais };

        decimal[] valoresMoedas = { 0.05m, 0.10m, 0.20m, 0.50m, 1.00m, 2.00m };

        //Criação da lista
        List<string> Items = new List<string>();

        //adiciona um café à lista e o preço ao total.
        private void lblMaisCafe_Click_1(object sender, EventArgs e)
        {
            contadorCafé++;
            lblquantidadeCafe.Text = contadorCafé.ToString();
            listBox1.Items.Add("Café - 0,25€");
            total += 0.25m;
            lblTotal.Text = total.ToString("0.00");
        }

        //Retira um café à lista e o preço ao total.
        private void lblMenosCafe_Click(object sender, EventArgs e)
        {
            if (contadorCafé > 0)
            {
                contadorCafé--;
                lblquantidadeCafe.Text = contadorCafé.ToString();
                listBox1.Items.Remove("Café - 0,25€");
                total -= 0.25m;
                lblTotal.Text = total.ToString("0.00");
            }
        }
        //Retira um cappuccino à lista e o preço ao total.
        private void lblMenosCappuccino_Click(object sender, EventArgs e)
        {
            if (contadorCappuccino > 0)
            {
                contadorCappuccino--;
                lblquantidadeCappuccino.Text = contadorCappuccino.ToString();
                listBox1.Items.Remove("Cappuccino - 0,30€");
                total -= 0.30m;
                lblTotal.Text = total.ToString("0.00");
            }
        }
        //adiciona um cappuccino à lista e o preço ao total.
        private void lblMaisCappuccino_Click(object sender, EventArgs e)
        {

            contadorCappuccino++;
            lblquantidadeCappuccino.Text = contadorCappuccino.ToString();
            listBox1.Items.Add("Cappuccino - 0,30€");
            total += 0.30m;
            lblTotal.Text = total.ToString("0.00");
        }

        //Retira um chocolate à lista e o preço ao total.
        private void lblMenosChocolate_Click(object sender, EventArgs e)
        {
            if (contadorChocolate > 0)
            {
                contadorChocolate--;
                lblquantidadeChocolate.Text = contadorChocolate.ToString();
                listBox1.Items.Remove("Chocolate - 0,35€");
                total -= 0.35m;
                lblTotal.Text = total.ToString("0.00");
            }
        }
        //adiciona um chocolate à lista e o preço ao total.
        private void lblMaisChocolate_Click(object sender, EventArgs e)
        {
            contadorChocolate++;
            lblquantidadeChocolate.Text = contadorChocolate.ToString();
            listBox1.Items.Add("Chocolate - 0,35€");
            total += 0.35m;
            lblTotal.Text = total.ToString("0.00");
        }
        //Retira um chá à lista e o preço ao total.
        private void lblMenosChá_Click(object sender, EventArgs e)
        {
            if (contadorCha > 0)
            {
                contadorCha--;
                lblquantidadeChá.Text = contadorCha.ToString();
                listBox1.Items.Remove("Chá - 0,20€");
                total -= 0.20m;
                lblTotal.Text = total.ToString("0.00");
            }
        }
        //adiciona um chá à lista e o preço ao total.
        private void lblMaisChá_Click(object sender, EventArgs e)
        {
            contadorCha++;
            lblquantidadeChá.Text = contadorCha.ToString();
            listBox1.Items.Add("Chá - 0,20€");
            total += 0.20m;
            lblTotal.Text = total.ToString("0.00");
        }
        //insere uma moeda de 0,05€ e atualiza o montante inserido se o moedeiro não estiver cheio.Se tiver exibe uma mensagem a avisar e a moeda é devolvida
        private void cincoCent_Click(object sender, EventArgs e)
        {
            if (moedeiro[0] < limiteMaximoMoedas)
            {
                moedeiro[0]++;
                montanteInserido += 0.05m;
                lblMontante.Text = montanteInserido.ToString();
            }
            else
            {
                MessageBox.Show($"Moedeiro de 0,05€ está cheio! A moeda será devolvida.");
                DevolverMoeda(0, 0.05m);
            }
        }
        //Insere uma moeda de 0,10€ e atualiza o montante inserido se o moedeiro não estiver cheio.Se tiver exibe uma mensagem a avisar.
        private void dezCent_Click(object sender, EventArgs e)
        {
            if (moedeiro[1] < limiteMaximoMoedas)
            {
                moedeiro[1]++;
                montanteInserido += 0.10m;
                lblMontante.Text = montanteInserido.ToString();
            }
            else
            {
                MessageBox.Show($"Moedeiro de 0,10€ está cheio! A moeda será devolvida.");
                DevolverMoeda(1, 0.10m);
            }
        }
        //insere uma moeda de 0,20€ e atualiza o montante inserido se o moedeiro não estiver cheio.Se tiver exibe uma mensagem a avisar.
        private void vinteCent_Click(object sender, EventArgs e)
        {
            if (moedeiro[2] < limiteMaximoMoedas)
            {
                moedeiro[2]++;
                montanteInserido += 0.20m;
                lblMontante.Text = montanteInserido.ToString();
            }
            else
            {
                MessageBox.Show($"Moedeiro de 0,20€ está cheio! A moeda será devolvida.");
                DevolverMoeda(2, 0.20m);
            }
        }
        //insere uma moeda de 0,50€ e atualiza o montante inserido se o moedeiro não estiver cheio.Se tiver exibe uma mensagem a avisar.
        private void cinquentaCent_Click(object sender, EventArgs e)
        {
            if (moedeiro[3] < limiteMaximoMoedas)
            {
                moedeiro[3]++;
                montanteInserido += 0.50m;
                lblMontante.Text = montanteInserido.ToString();
            }
            else
            {
                MessageBox.Show($"Moedeiro de 0,50€ está cheio! A moeda será devolvida.");
                DevolverMoeda(3, 0.50m);
            }
        }
        //insere uma moeda de 1,00€ e atualiza o montante inserido se o moedeiro não estiver cheio.Se tiver exibe uma mensagem a avisar.
        private void umEuro_Click(object sender, EventArgs e)
        {
            if (moedeiro[4] < limiteMaximoMoedas)
            {
                
                moedeiro[4]++;
                montanteInserido += 1.00m;
                lblMontante.Text = montanteInserido.ToString();
            }
            else
            {
                MessageBox.Show($"Moedeiro de 1,00€ está cheio! A moeda será devolvida.");
                DevolverMoeda(4, 1.00m);
            }
        }
        //insere uma moeda de 2,00€ e atualiza o montante inserido se o moedeiro não estiver cheio.Se tiver exibe uma mensagem a avisar.
        private void doisEuros_Click(object sender, EventArgs e)
        {
            if (moedeiro[5] < limiteMaximoMoedas)
            {
                moedeiro[5]++;
                montanteInserido += 2.00m;
                lblMontante.Text = montanteInserido.ToString();
            }
            else
            {
                MessageBox.Show($"Moedeiro de 2,00€ está cheio! A moeda será devolvida.");
                DevolverMoeda(5, 2.00m);
            }
        }

        //Confirma a compra e calcula o troco
        private void confirmarCompra_Click(object sender, EventArgs e)
        {
            if (montanteInserido < total)
            {
                MessageBox.Show("O montante inserido é insuficiente");
            }
            else
            {
                // Chama o método para devolver troco 
                troco = montanteInserido - total;

                int[]? quantidadeMoedas = CalcularTroco(troco);

                if (quantidadeMoedas == null)
                {
                    troco = montanteInserido;
                    // Mostra uma mensagem informando que não há troco disponível
                    MessageBox.Show("Não há moedas suficientes para dar troco.");

                    // Devolve o montante inserido
                    quantidadeMoedas = CalcularTroco(montanteInserido);

                }
                AtualizarMoedeiro(quantidadeMoedas);

                MostrarMoedasADevolver(quantidadeMoedas);

                ResetarCompra();
            }
        }

        //Reseta os dados da compra e se o user inseriu moedas, ele devolve o montante.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Verifica se o montante inserido é maior que zero, indicando que a compra foi iniciada
            if (montanteInserido > 0)
            {
                // Define o troco como o montante inserido
                troco = montanteInserido;
                // Calcula a quantidade de moedas a serem devolvidas como troco com base no montante inserido
                int[]? quantidadeMoedas = CalcularTroco(montanteInserido);

                // Atualiza o estoque de moedas disponíveis no moedeiro após a devolução do troco
                AtualizarMoedeiro(quantidadeMoedas);

                // Mostra as moedas que serão devolvidas como troco
                MostrarMoedasADevolver(quantidadeMoedas);
            }
            // Reseta os dados da compra, preparando o sistema para uma nova transação
            ResetarCompra();            
        }
        private void DevolverMoeda(int indiceMoeda, decimal valorMoeda)
        {
            // Reduzir a contagem da moeda inserida
            moedeiro[indiceMoeda]--;

            // Subtrair o valor da moeda do montante total inserido

            if (montanteInserido > 0)
            {
                montanteInserido -= valorMoeda;
                lblMontante.Text = montanteInserido.ToString();
            }
        }       
        //Método para as moedas que vão ser devolvidas
        private int[]? CalcularTroco(decimal troco)
        {
            // Cria uma cópia temporária do moedeiro para evitar alterar o moedeiro original e para não reduzir 2 vezes o moedeiro.
            int[] moedeiroTemporario = (int[])moedeiro.Clone();

            // Array que vai armazenar a quantidade de cada moeda que será devolvida como troco.
            int[] quantidadeMoedas = new int[valoresMoedas.Length];

            // Itera sobre cada valor de moeda disponível.
            for (int i = valoresMoedas.Length - 1; i >= 0; i--)
            {
                // Enquanto o troco a ser devolvido for maior ou igual ao valor da moeda atual e ainda houver moedas disponíveis desse valor...
                while (troco >= valoresMoedas[i] && moedeiroTemporario[i] > 0)
                {
                    // Subtrai o valor da moeda atual do troco.
                    troco -= valoresMoedas[i];

                    // Incrementa a quantidade de moedas daquele valor que será devolvida como troco.
                    quantidadeMoedas[i]++;

                    // Decrementa a quantidade de moedas disponíveis desse valor.
                    moedeiroTemporario[i]--;
                }
            }
            if (troco > 0)
            {
                // Se o troco for maior que zero, significa que não foi possível devolver o troco exato com as moedas disponíveis.
                // Portanto, retorna null para indicar que não há moedas suficientes para dar o troco exato.
                return null;
            }
            else
            {
                // Se o troco for igual ou menor que zero, significa que foi possível devolver o troco exato com as moedas disponíveis.
                // Retorna a quantidade de moedas a serem devolvidas.
                return quantidadeMoedas;
            }
        }
        //Método para mostrar as moedas que serão devolvidas no troco
        private void MostrarMoedasADevolver(int[]? quantidadeMoedas)
        {
            if (quantidadeMoedas != null)
            {
                // Variável para armazenar a mensagem de troco
                string mensagem = $"O seu troco é: {troco} €\n\n\nMoedas:\n ";

                // Iterar sobre as moedas e adicionar a quantidade ao troco, se houver

                for (int i = quantidadeMoedas.Length - 1; i >= 0; i--)
                {
                    if (quantidadeMoedas[i] > 0)
                    {
                        // Concatenar a quantidade de moedas e o valor da moeda ao troco
                        mensagem += $"{quantidadeMoedas[i]}  de  {valoresMoedas[i]}€\n ";
                    }
                }
                // Atualiza a label com a quantidade de moedas devolvidas
                MessageBox.Show(mensagem);
            }
        }
        private void AtualizarMoedeiro(int[]? quantidadeMoedas)
        {
            // Verifica se a quantidade de moedas a serem devolvidas não é nula
            if (quantidadeMoedas != null)
            {
                // Itera sobre as moedas disponíveis (do maior valor para o menor)
                for (int i = quantidadeMoedas.Length - 1; i >= 0; i--)
                {
                    // Itera sobre a quantidade de moedas específica para esse valor
                    for (int j = 0; j < quantidadeMoedas[i]; j++)
                    {
                        // Reduz a quantidade de moedas disponíveis desse valor no moedeiro
                        moedeiro[i]--;
                    }
                }
            }           
        }
        private void ResetarCompra()
        {
            troco = 0.00m;
            montanteInserido = 0.00m;
            lblMontante.Text = montanteInserido.ToString();
            total = 0.00m;           
            contadorCafé = 0;
            contadorChocolate = 0;
            contadorCappuccino = 0;
            contadorCha = 0;
            listBox1.Items.Clear();          
            lblTotal.Text = total.ToString();
            lblquantidadeCafe.Text = contadorCafé.ToString();
            lblquantidadeChá.Text = contadorCafé.ToString();
            lblquantidadeChocolate.Text = contadorCafé.ToString();
            lblquantidadeCappuccino.Text = contadorCafé.ToString();
        }
    }
}

