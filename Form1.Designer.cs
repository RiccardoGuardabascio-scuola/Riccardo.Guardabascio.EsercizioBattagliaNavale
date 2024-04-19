namespace Riccardo.Guardabascio.EsercizioBattagliaNavale
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
            lblGiocatore = new Label();
            btnGeneraScenario = new Button();
            lblRiga = new Label();
            lblColonna = new Label();
            txtRiga = new TextBox();
            textBox1 = new TextBox();
            btnColpire = new Button();
            lblNaviRimaste = new Label();
            lblNumeroNavi = new Label();
            lstCampo = new ListBox();
            lblCampo = new Label();
            lblColpo = new Label();
            btnTurno = new Button();
            SuspendLayout();
            // 
            // lblGiocatore
            // 
            lblGiocatore.AutoSize = true;
            lblGiocatore.Location = new Point(32, 17);
            lblGiocatore.Name = "lblGiocatore";
            lblGiocatore.Size = new Size(38, 15);
            lblGiocatore.TabIndex = 0;
            lblGiocatore.Text = "label1";
            // 
            // btnGeneraScenario
            // 
            btnGeneraScenario.Location = new Point(542, 13);
            btnGeneraScenario.Name = "btnGeneraScenario";
            btnGeneraScenario.Size = new Size(100, 23);
            btnGeneraScenario.TabIndex = 1;
            btnGeneraScenario.Text = "Genera scenario";
            btnGeneraScenario.UseVisualStyleBackColor = true;
            // 
            // lblRiga
            // 
            lblRiga.AutoSize = true;
            lblRiga.Location = new Point(53, 80);
            lblRiga.Name = "lblRiga";
            lblRiga.Size = new Size(30, 15);
            lblRiga.TabIndex = 2;
            lblRiga.Text = "Riga";
            // 
            // lblColonna
            // 
            lblColonna.AutoSize = true;
            lblColonna.Location = new Point(53, 114);
            lblColonna.Name = "lblColonna";
            lblColonna.Size = new Size(52, 15);
            lblColonna.TabIndex = 2;
            lblColonna.Text = "Colonna";
            lblColonna.Click += label2_Click;
            // 
            // txtRiga
            // 
            txtRiga.Location = new Point(123, 77);
            txtRiga.Name = "txtRiga";
            txtRiga.Size = new Size(100, 23);
            txtRiga.TabIndex = 3;
            txtRiga.TextChanged += txtRiga_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += txtRiga_TextChanged;
            // 
            // btnColpire
            // 
            btnColpire.Location = new Point(271, 94);
            btnColpire.Name = "btnColpire";
            btnColpire.Size = new Size(83, 23);
            btnColpire.TabIndex = 4;
            btnColpire.Text = "Colpire";
            btnColpire.UseVisualStyleBackColor = true;
            // 
            // lblNaviRimaste
            // 
            lblNaviRimaste.AutoSize = true;
            lblNaviRimaste.Location = new Point(53, 171);
            lblNaviRimaste.Name = "lblNaviRimaste";
            lblNaviRimaste.Size = new Size(197, 15);
            lblNaviRimaste.TabIndex = 5;
            lblNaviRimaste.Text = "Navi rimaste al giocatore avversario:";
            // 
            // lblNumeroNavi
            // 
            lblNumeroNavi.AutoSize = true;
            lblNumeroNavi.Location = new Point(256, 171);
            lblNumeroNavi.Name = "lblNumeroNavi";
            lblNumeroNavi.Size = new Size(38, 15);
            lblNumeroNavi.TabIndex = 6;
            lblNumeroNavi.Text = "label1";
            lblNumeroNavi.Click += label1_Click;
            // 
            // lstCampo
            // 
            lstCampo.FormattingEnabled = true;
            lstCampo.ItemHeight = 15;
            lstCampo.Location = new Point(459, 94);
            lstCampo.Name = "lstCampo";
            lstCampo.Size = new Size(258, 139);
            lstCampo.TabIndex = 7;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(421, 76);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(367, 15);
            lblCampo.TabIndex = 8;
            lblCampo.Text = "Il tuo campo(1=nave, 0=acqua, 2=punto colpito, x=nave affondata):";
            // 
            // lblColpo
            // 
            lblColpo.AutoSize = true;
            lblColpo.Location = new Point(153, 218);
            lblColpo.Name = "lblColpo";
            lblColpo.Size = new Size(38, 15);
            lblColpo.TabIndex = 9;
            lblColpo.Text = "label1";
            // 
            // btnTurno
            // 
            btnTurno.Location = new Point(97, 260);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(153, 23);
            btnTurno.TabIndex = 10;
            btnTurno.Text = "Passa al turno successivo";
            btnTurno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(btnTurno);
            Controls.Add(lblColpo);
            Controls.Add(lblCampo);
            Controls.Add(lstCampo);
            Controls.Add(lblNumeroNavi);
            Controls.Add(lblNaviRimaste);
            Controls.Add(btnColpire);
            Controls.Add(textBox1);
            Controls.Add(txtRiga);
            Controls.Add(lblColonna);
            Controls.Add(lblRiga);
            Controls.Add(btnGeneraScenario);
            Controls.Add(lblGiocatore);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGiocatore;
        private Button btnGeneraScenario;
        private Label lblRiga;
        private Label lblColonna;
        private TextBox txtRiga;
        private TextBox textBox1;
        private Button btnColpire;
        private Label lblNaviRimaste;
        private Label lblNumeroNavi;
        private ListBox lstCampo;
        private Label lblCampo;
        private Label lblColpo;
        private Button btnTurno;
    }
}
