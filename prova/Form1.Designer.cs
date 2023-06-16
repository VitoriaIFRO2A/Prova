namespace prova
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
            button1 = new Button();
            label1 = new Label();
            md_matricula = new MaskedTextBox();
            md_funçao = new ComboBox();
            label2 = new Label();
            mb_cpf = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            md_nome = new TextBox();
            label5 = new Label();
            label6 = new Label();
            md_salario = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(115, 329);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 108);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 1;
            label1.Text = "Matricula:";
            // 
            // md_matricula
            // 
            md_matricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            md_matricula.Location = new Point(134, 116);
            md_matricula.Name = "md_matricula";
            md_matricula.Size = new Size(158, 29);
            md_matricula.TabIndex = 2;
            md_matricula.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // md_funçao
            // 
            md_funçao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            md_funçao.FormattingEnabled = true;
            md_funçao.Items.AddRange(new object[] { "Medico", "TI", "ADM" });
            md_funçao.Location = new Point(115, 230);
            md_funçao.Name = "md_funçao";
            md_funçao.Size = new Size(121, 29);
            md_funçao.TabIndex = 3;
            md_funçao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(307, 116);
            label2.Name = "label2";
            label2.Size = new Size(53, 30);
            label2.TabIndex = 5;
            label2.Text = "CPF:";
            label2.Click += label2_Click;
            // 
            // mb_cpf
            // 
            mb_cpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mb_cpf.Location = new Point(366, 117);
            mb_cpf.Mask = "___,___,___-__";
            mb_cpf.Name = "mb_cpf";
            mb_cpf.Size = new Size(100, 29);
            mb_cpf.TabIndex = 6;
            mb_cpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 36);
            label3.Name = "label3";
            label3.Size = new Size(306, 37);
            label3.TabIndex = 7;
            label3.Text = "Cadastro de Funcionairo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 163);
            label4.Name = "label4";
            label4.Size = new Size(96, 37);
            label4.TabIndex = 8;
            label4.Text = "Nome:";
            label4.Click += label4_Click;
            // 
            // md_nome
            // 
            md_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            md_nome.Location = new Point(115, 175);
            md_nome.Name = "md_nome";
            md_nome.Size = new Size(372, 29);
            md_nome.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 222);
            label5.Name = "label5";
            label5.Size = new Size(108, 37);
            label5.TabIndex = 10;
            label5.Text = "Função:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(253, 222);
            label6.Name = "label6";
            label6.Size = new Size(104, 37);
            label6.TabIndex = 11;
            label6.Text = "Salario:";
            // 
            // md_salario
            // 
            md_salario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            md_salario.Location = new Point(363, 230);
            md_salario.Name = "md_salario";
            md_salario.Size = new Size(100, 29);
            md_salario.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(307, 329);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(671, 455);
            Controls.Add(button2);
            Controls.Add(md_salario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(md_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mb_cpf);
            Controls.Add(label2);
            Controls.Add(md_funçao);
            Controls.Add(md_matricula);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private MaskedTextBox md_matricula;
        private ComboBox md_funçao;
        private Label label2;
        private MaskedTextBox mb_cpf;
        private Label label3;
        private Label label4;
        private TextBox md_nome;
        private Label label5;
        private Label label6;
        private TextBox md_salario;
        private Button button2;
    }
}