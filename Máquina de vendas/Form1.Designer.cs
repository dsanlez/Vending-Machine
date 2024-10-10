namespace Máquina_de_vendas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblCha = new Label();
            lblChocolate = new Label();
            lblCappuccino = new Label();
            lblCafé = new Label();
            lblMenosCafe = new Label();
            lblquantidadeCafe = new Label();
            lblMaisCafe = new Label();
            lblMenosCappuccino = new Label();
            lblquantidadeCappuccino = new Label();
            lblMaisCappuccino = new Label();
            lblMenosChocolate = new Label();
            lblquantidadeChocolate = new Label();
            lblMaisChocolate = new Label();
            lblMenosChá = new Label();
            lblquantidadeChá = new Label();
            lblMaisChá = new Label();
            lbl = new Label();
            label10 = new Label();
            lblMontante = new Label();
            lblTotal = new Label();
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cincoCent = new PictureBox();
            dezCent = new PictureBox();
            vinteCent = new PictureBox();
            cinquentaCent = new PictureBox();
            umEuro = new PictureBox();
            doisEuros = new PictureBox();
            confirmarCompra = new Button();
            label1 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cincoCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dezCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vinteCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cinquentaCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umEuro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doisEuros).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.istockphoto_1303583671_612x612;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1079, 629);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCha
            // 
            lblCha.AutoSize = true;
            lblCha.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCha.ForeColor = Color.NavajoWhite;
            lblCha.Location = new Point(622, 171);
            lblCha.Name = "lblCha";
            lblCha.Size = new Size(240, 26);
            lblCha.TabIndex = 1;
            lblCha.Text = "Chá                      0,20€";
            // 
            // lblChocolate
            // 
            lblChocolate.AutoSize = true;
            lblChocolate.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChocolate.ForeColor = Color.NavajoWhite;
            lblChocolate.Location = new Point(622, 117);
            lblChocolate.Name = "lblChocolate";
            lblChocolate.Size = new Size(241, 26);
            lblChocolate.TabIndex = 2;
            lblChocolate.Text = "Chocolate            0,35€";
            // 
            // lblCappuccino
            // 
            lblCappuccino.AutoSize = true;
            lblCappuccino.BackColor = Color.Transparent;
            lblCappuccino.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCappuccino.ForeColor = Color.NavajoWhite;
            lblCappuccino.Location = new Point(622, 67);
            lblCappuccino.Name = "lblCappuccino";
            lblCappuccino.Size = new Size(242, 26);
            lblCappuccino.TabIndex = 3;
            lblCappuccino.Text = "Cappuccino         0,30€";
            // 
            // lblCafé
            // 
            lblCafé.AutoSize = true;
            lblCafé.BackColor = Color.Transparent;
            lblCafé.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCafé.ForeColor = Color.NavajoWhite;
            lblCafé.Location = new Point(622, 21);
            lblCafé.Name = "lblCafé";
            lblCafé.Size = new Size(237, 24);
            lblCafé.TabIndex = 4;
            lblCafé.Text = "Café                           0,25€";
            // 
            // lblMenosCafe
            // 
            lblMenosCafe.AutoSize = true;
            lblMenosCafe.Font = new Font("Segoe UI", 12F);
            lblMenosCafe.Location = new Point(905, 21);
            lblMenosCafe.Name = "lblMenosCafe";
            lblMenosCafe.Size = new Size(16, 21);
            lblMenosCafe.TabIndex = 5;
            lblMenosCafe.Text = "-";
            lblMenosCafe.Click += lblMenosCafe_Click;
            // 
            // lblquantidadeCafe
            // 
            lblquantidadeCafe.AutoSize = true;
            lblquantidadeCafe.BackColor = Color.NavajoWhite;
            lblquantidadeCafe.Font = new Font("Segoe UI", 12F);
            lblquantidadeCafe.Location = new Point(955, 21);
            lblquantidadeCafe.Name = "lblquantidadeCafe";
            lblquantidadeCafe.Size = new Size(19, 21);
            lblquantidadeCafe.TabIndex = 6;
            lblquantidadeCafe.Text = "0";
            // 
            // lblMaisCafe
            // 
            lblMaisCafe.AutoSize = true;
            lblMaisCafe.Font = new Font("Segoe UI", 12F);
            lblMaisCafe.Location = new Point(1009, 21);
            lblMaisCafe.Name = "lblMaisCafe";
            lblMaisCafe.Size = new Size(21, 21);
            lblMaisCafe.TabIndex = 7;
            lblMaisCafe.Text = "+";
            lblMaisCafe.Click += lblMaisCafe_Click_1;
            // 
            // lblMenosCappuccino
            // 
            lblMenosCappuccino.AutoSize = true;
            lblMenosCappuccino.Font = new Font("Segoe UI", 12F);
            lblMenosCappuccino.Location = new Point(905, 73);
            lblMenosCappuccino.Name = "lblMenosCappuccino";
            lblMenosCappuccino.Size = new Size(16, 21);
            lblMenosCappuccino.TabIndex = 5;
            lblMenosCappuccino.Text = "-";
            lblMenosCappuccino.Click += lblMenosCappuccino_Click;
            // 
            // lblquantidadeCappuccino
            // 
            lblquantidadeCappuccino.AutoSize = true;
            lblquantidadeCappuccino.BackColor = Color.NavajoWhite;
            lblquantidadeCappuccino.Font = new Font("Segoe UI", 12F);
            lblquantidadeCappuccino.Location = new Point(955, 72);
            lblquantidadeCappuccino.Name = "lblquantidadeCappuccino";
            lblquantidadeCappuccino.Size = new Size(19, 21);
            lblquantidadeCappuccino.TabIndex = 6;
            lblquantidadeCappuccino.Text = "0";
            // 
            // lblMaisCappuccino
            // 
            lblMaisCappuccino.AutoSize = true;
            lblMaisCappuccino.Font = new Font("Segoe UI", 12F);
            lblMaisCappuccino.Location = new Point(1009, 72);
            lblMaisCappuccino.Name = "lblMaisCappuccino";
            lblMaisCappuccino.Size = new Size(21, 21);
            lblMaisCappuccino.TabIndex = 7;
            lblMaisCappuccino.Text = "+";
            lblMaisCappuccino.Click += lblMaisCappuccino_Click;
            // 
            // lblMenosChocolate
            // 
            lblMenosChocolate.AutoSize = true;
            lblMenosChocolate.Font = new Font("Segoe UI", 12F);
            lblMenosChocolate.Location = new Point(905, 121);
            lblMenosChocolate.Name = "lblMenosChocolate";
            lblMenosChocolate.Size = new Size(16, 21);
            lblMenosChocolate.TabIndex = 5;
            lblMenosChocolate.Text = "-";
            lblMenosChocolate.Click += lblMenosChocolate_Click;
            // 
            // lblquantidadeChocolate
            // 
            lblquantidadeChocolate.AutoSize = true;
            lblquantidadeChocolate.BackColor = Color.NavajoWhite;
            lblquantidadeChocolate.Font = new Font("Segoe UI", 12F);
            lblquantidadeChocolate.Location = new Point(955, 121);
            lblquantidadeChocolate.Name = "lblquantidadeChocolate";
            lblquantidadeChocolate.Size = new Size(19, 21);
            lblquantidadeChocolate.TabIndex = 6;
            lblquantidadeChocolate.Text = "0";
            // 
            // lblMaisChocolate
            // 
            lblMaisChocolate.AutoSize = true;
            lblMaisChocolate.Font = new Font("Segoe UI", 12F);
            lblMaisChocolate.Location = new Point(1009, 121);
            lblMaisChocolate.Name = "lblMaisChocolate";
            lblMaisChocolate.Size = new Size(21, 21);
            lblMaisChocolate.TabIndex = 7;
            lblMaisChocolate.Text = "+";
            lblMaisChocolate.Click += lblMaisChocolate_Click;
            // 
            // lblMenosChá
            // 
            lblMenosChá.AutoSize = true;
            lblMenosChá.Font = new Font("Segoe UI", 12F);
            lblMenosChá.Location = new Point(905, 176);
            lblMenosChá.Name = "lblMenosChá";
            lblMenosChá.Size = new Size(16, 21);
            lblMenosChá.TabIndex = 5;
            lblMenosChá.Text = "-";
            lblMenosChá.Click += lblMenosChá_Click;
            // 
            // lblquantidadeChá
            // 
            lblquantidadeChá.AutoSize = true;
            lblquantidadeChá.BackColor = Color.NavajoWhite;
            lblquantidadeChá.Font = new Font("Segoe UI", 12F);
            lblquantidadeChá.Location = new Point(955, 176);
            lblquantidadeChá.Name = "lblquantidadeChá";
            lblquantidadeChá.Size = new Size(19, 21);
            lblquantidadeChá.TabIndex = 6;
            lblquantidadeChá.Text = "0";
            // 
            // lblMaisChá
            // 
            lblMaisChá.AutoSize = true;
            lblMaisChá.Font = new Font("Segoe UI", 12F);
            lblMaisChá.Location = new Point(1009, 176);
            lblMaisChá.Name = "lblMaisChá";
            lblMaisChá.Size = new Size(21, 21);
            lblMaisChá.TabIndex = 7;
            lblMaisChá.Text = "+";
            lblMaisChá.Click += lblMaisChá_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.NavajoWhite;
            lbl.Location = new Point(622, 220);
            lbl.Name = "lbl";
            lbl.Size = new Size(156, 26);
            lbl.TabIndex = 1;
            lbl.Text = "Total a pagar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.NavajoWhite;
            label10.Location = new Point(622, 270);
            label10.Name = "label10";
            label10.Size = new Size(209, 26);
            label10.TabIndex = 1;
            label10.Text = "Montante inserido:";
            // 
            // lblMontante
            // 
            lblMontante.AutoSize = true;
            lblMontante.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontante.ForeColor = Color.NavajoWhite;
            lblMontante.Location = new Point(980, 271);
            lblMontante.Name = "lblMontante";
            lblMontante.Size = new Size(50, 25);
            lblMontante.TabIndex = 9;
            lblMontante.Text = "0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.NavajoWhite;
            lblTotal.Location = new Point(980, 221);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 25);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "0,00";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.SaddleBrown;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.NavajoWhite;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 252);
            listBox1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(cincoCent);
            flowLayoutPanel1.Controls.Add(dezCent);
            flowLayoutPanel1.Controls.Add(vinteCent);
            flowLayoutPanel1.Controls.Add(cinquentaCent);
            flowLayoutPanel1.Controls.Add(umEuro);
            flowLayoutPanel1.Controls.Add(doisEuros);
            flowLayoutPanel1.Location = new Point(275, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 249);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // cincoCent
            // 
            cincoCent.Image = Properties.Resources._5centimos;
            cincoCent.Location = new Point(3, 3);
            cincoCent.Name = "cincoCent";
            cincoCent.Size = new Size(131, 77);
            cincoCent.SizeMode = PictureBoxSizeMode.StretchImage;
            cincoCent.TabIndex = 0;
            cincoCent.TabStop = false;
            cincoCent.Click += cincoCent_Click;
            // 
            // dezCent
            // 
            dezCent.Image = Properties.Resources._10_cent;
            dezCent.Location = new Point(140, 3);
            dezCent.Name = "dezCent";
            dezCent.Size = new Size(131, 77);
            dezCent.SizeMode = PictureBoxSizeMode.StretchImage;
            dezCent.TabIndex = 0;
            dezCent.TabStop = false;
            dezCent.Click += dezCent_Click;
            // 
            // vinteCent
            // 
            vinteCent.Image = Properties.Resources._20_cent;
            vinteCent.Location = new Point(3, 86);
            vinteCent.Name = "vinteCent";
            vinteCent.Size = new Size(131, 77);
            vinteCent.SizeMode = PictureBoxSizeMode.StretchImage;
            vinteCent.TabIndex = 0;
            vinteCent.TabStop = false;
            vinteCent.Click += vinteCent_Click;
            // 
            // cinquentaCent
            // 
            cinquentaCent.Image = Properties.Resources._50_cent;
            cinquentaCent.Location = new Point(140, 86);
            cinquentaCent.Name = "cinquentaCent";
            cinquentaCent.Size = new Size(131, 77);
            cinquentaCent.SizeMode = PictureBoxSizeMode.StretchImage;
            cinquentaCent.TabIndex = 0;
            cinquentaCent.TabStop = false;
            cinquentaCent.Click += cinquentaCent_Click;
            // 
            // umEuro
            // 
            umEuro.Image = (Image)resources.GetObject("umEuro.Image");
            umEuro.Location = new Point(3, 169);
            umEuro.Name = "umEuro";
            umEuro.Size = new Size(131, 77);
            umEuro.SizeMode = PictureBoxSizeMode.Zoom;
            umEuro.TabIndex = 0;
            umEuro.TabStop = false;
            umEuro.Click += umEuro_Click;
            // 
            // doisEuros
            // 
            doisEuros.Image = Properties.Resources._2_euro;
            doisEuros.Location = new Point(140, 169);
            doisEuros.Name = "doisEuros";
            doisEuros.Size = new Size(131, 77);
            doisEuros.SizeMode = PictureBoxSizeMode.StretchImage;
            doisEuros.TabIndex = 0;
            doisEuros.TabStop = false;
            doisEuros.Click += doisEuros_Click;
            // 
            // confirmarCompra
            // 
            confirmarCompra.BackColor = Color.NavajoWhite;
            confirmarCompra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmarCompra.Location = new Point(846, 405);
            confirmarCompra.Name = "confirmarCompra";
            confirmarCompra.Size = new Size(152, 57);
            confirmarCompra.TabIndex = 14;
            confirmarCompra.Text = "Confirmar ";
            confirmarCompra.UseVisualStyleBackColor = false;
            confirmarCompra.Click += confirmarCompra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 15;
            label1.Text = "Insira o montante ";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.NavajoWhite;
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(622, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 57);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 629);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(confirmarCompra);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(listBox1);
            Controls.Add(lblTotal);
            Controls.Add(lblMontante);
            Controls.Add(lblMaisChá);
            Controls.Add(lblquantidadeChá);
            Controls.Add(lblMaisChocolate);
            Controls.Add(lblquantidadeChocolate);
            Controls.Add(lblMaisCappuccino);
            Controls.Add(lblMenosChá);
            Controls.Add(lblquantidadeCappuccino);
            Controls.Add(lblMenosChocolate);
            Controls.Add(lblMaisCafe);
            Controls.Add(lblMenosCappuccino);
            Controls.Add(lblquantidadeCafe);
            Controls.Add(lblMenosCafe);
            Controls.Add(lblCafé);
            Controls.Add(lblCappuccino);
            Controls.Add(lblChocolate);
            Controls.Add(label10);
            Controls.Add(lbl);
            Controls.Add(lblCha);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cincoCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dezCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)vinteCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)cinquentaCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)umEuro).EndInit();
            ((System.ComponentModel.ISupportInitialize)doisEuros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCha;
        private Label lblChocolate;
        private Label lblCappuccino;
        private Label lblCafé;
        private Label lblMenosCafe;
        private Label lblquantidadeCafe;
        private Label lblMaisCafe;
        private Label lblMenosCappuccino;
        private Label lblquantidadeCappuccino;
        private Label lblMaisCappuccino;
        private Label lblMenosChocolate;
        private Label lblquantidadeChocolate;
        private Label lblMaisChocolate;
        private Label lblMenosChá;
        private Label lblquantidadeChá;
        private Label lblMaisChá;
        private Label lbl;
        private Label label10;
      
        private Label lblMontante;
        private Label lblTotal;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox cincoCent;
        private PictureBox dezCent;
        private PictureBox vinteCent;
        private PictureBox cinquentaCent;
        private PictureBox umEuro;
        private PictureBox doisEuros;
        private Button confirmarCompra;
        private Label label1;
        private Button btnCancelar;
    }
}
