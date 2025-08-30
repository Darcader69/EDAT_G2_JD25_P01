using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos.Aleatorios
{
    public partial class frmDatosAleatorio : Form
    {
        Random rnd = new Random();

        public frmDatosAleatorio()
        {
            InitializeComponent();
            GenNumRand.Click += GenNumRand_Click;
        }

        private void frmDatosAleatorio_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                GrpSel.Items.Add(c.ToString());
            }
        }

        private void GenNumRand_Click(object sender, EventArgs e)
        {
            Aleatorio emp = GenerarAleatorio();

            NumBox.Text = emp.Numero.ToString();
            NomBox.Text = emp.Nombre;
            dateFNac.Value = emp.FechaNacimiento;

            if (emp.Sexo == "Masculino")
                MASC.Checked = true;
            else
                FEM.Checked = true;

            GrpSel.SelectedItem = emp.Grupo;
            Sueldobox.Text = emp.Sueldo.ToString("F2");
            SegMed.Checked = emp.SeguroMedico;
        }

        private Aleatorio GenerarAleatorio()
        {
            Aleatorio emp = new Aleatorio
            {
                Numero = rnd.Next(1000, 9999),
                Nombre = new[] { "Juan", "Ana", "Pablo", "Marta", "Luis", "Sofía", "Esteban", "Tanya" }[rnd.Next(8)],
                FechaNacimiento = new DateTime(1970, 1, 1).AddDays(
                    rnd.Next((new DateTime(2005, 12, 31) - new DateTime(1970, 1, 1)).Days)
                ),
                Sexo = rnd.Next(2) == 0 ? "Masculino" : "Femenino",
                Grupo = ((char)rnd.Next('A', 'Z' + 1)).ToString(),
                Sueldo = rnd.Next(6000, 50001),
                SeguroMedico = rnd.Next(2) == 1
            };

            return emp;
        }
        private Label DEmp;
        private Label Num;

        private void InitializeComponent()
        {
            DEmp = new Label();
            Num = new Label();
            Nom = new Label();
            FNac = new Label();
            NumBox = new TextBox();
            NomBox = new TextBox();
            dateFNac = new DateTimePicker();
            MASC = new RadioButton();
            FEM = new RadioButton();
            Grp = new Label();
            GrpSel = new ComboBox();
            Sueldo = new Label();
            Sueldobox = new TextBox();
            SegMed = new RadioButton();
            GenNumRand = new Button();
            SuspendLayout();
            // 
            // DEmp
            // 
            DEmp.AutoSize = true;
            DEmp.Location = new Point(38, 45);
            DEmp.Name = "DEmp";
            DEmp.Size = new Size(145, 20);
            DEmp.TabIndex = 0;
            DEmp.Text = "Datos del Empleado";
            // 
            // Num
            // 
            Num.AutoSize = true;
            Num.Location = new Point(78, 91);
            Num.Name = "Num";
            Num.Size = new Size(63, 20);
            Num.TabIndex = 1;
            Num.Text = "Número";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(77, 124);
            Nom.Name = "Nom";
            Nom.Size = new Size(64, 20);
            Nom.TabIndex = 2;
            Nom.Text = "Nombre";
            // 
            // FNac
            // 
            FNac.AutoSize = true;
            FNac.Location = new Point(77, 169);
            FNac.Name = "FNac";
            FNac.Size = new Size(149, 20);
            FNac.TabIndex = 3;
            FNac.Text = "Fecha de Nacimiento";
            // 
            // NumBox
            // 
            NumBox.Location = new Point(147, 91);
            NumBox.Name = "NumBox";
            NumBox.Size = new Size(374, 27);
            NumBox.TabIndex = 4;
            // 
            // NomBox
            // 
            NomBox.Location = new Point(147, 124);
            NomBox.Name = "NomBox";
            NomBox.Size = new Size(374, 27);
            NomBox.TabIndex = 5;
            // 
            // dateFNac
            // 
            dateFNac.Location = new Point(232, 169);
            dateFNac.Name = "dateFNac";
            dateFNac.Size = new Size(287, 27);
            dateFNac.TabIndex = 6;
            // 
            // MASC
            // 
            MASC.AutoSize = true;
            MASC.Location = new Point(161, 207);
            MASC.Name = "MASC";
            MASC.Size = new Size(97, 24);
            MASC.TabIndex = 7;
            MASC.TabStop = true;
            MASC.Text = "Masculino";
            MASC.UseVisualStyleBackColor = true;
            // 
            // FEM
            // 
            FEM.AutoSize = true;
            FEM.Location = new Point(161, 237);
            FEM.Name = "FEM";
            FEM.Size = new Size(95, 24);
            FEM.TabIndex = 8;
            FEM.TabStop = true;
            FEM.Text = "Femenino";
            FEM.UseVisualStyleBackColor = true;
            // 
            // Grp
            // 
            Grp.AutoSize = true;
            Grp.Location = new Point(76, 287);
            Grp.Name = "Grp";
            Grp.Size = new Size(50, 20);
            Grp.TabIndex = 9;
            Grp.Text = "Grupo";
            // 
            // GrpSel
            // 
            GrpSel.FormattingEnabled = true;
            GrpSel.Location = new Point(137, 287);
            GrpSel.Name = "GrpSel";
            GrpSel.Size = new Size(151, 28);
            GrpSel.TabIndex = 10;
            // 
            // Sueldo
            // 
            Sueldo.AutoSize = true;
            Sueldo.Location = new Point(76, 325);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(55, 20);
            Sueldo.TabIndex = 11;
            Sueldo.Text = "Sueldo";
            // 
            // Sueldobox
            // 
            Sueldobox.Location = new Point(137, 325);
            Sueldobox.Name = "Sueldobox";
            Sueldobox.Size = new Size(154, 27);
            Sueldobox.TabIndex = 12;
            // 
            // SegMed
            // 
            SegMed.AutoSize = true;
            SegMed.Location = new Point(277, 377);
            SegMed.Name = "SegMed";
            SegMed.Size = new Size(131, 24);
            SegMed.TabIndex = 13;
            SegMed.TabStop = true;
            SegMed.Text = "Seguro médico";
            SegMed.UseVisualStyleBackColor = true;
            // 
            // GenNumRand
            // 
            GenNumRand.Location = new Point(214, 407);
            GenNumRand.Name = "GenNumRand";
            GenNumRand.Size = new Size(270, 29);
            GenNumRand.TabIndex = 14;
            GenNumRand.Text = "Generar números aleatorios";
            GenNumRand.UseVisualStyleBackColor = true;
            // 
            // frmDatosAleatorio
            // 
            ClientSize = new Size(657, 461);
            Controls.Add(GenNumRand);
            Controls.Add(SegMed);
            Controls.Add(Sueldobox);
            Controls.Add(Sueldo);
            Controls.Add(GrpSel);
            Controls.Add(Grp);
            Controls.Add(FEM);
            Controls.Add(MASC);
            Controls.Add(dateFNac);
            Controls.Add(NomBox);
            Controls.Add(NumBox);
            Controls.Add(FNac);
            Controls.Add(Nom);
            Controls.Add(Num);
            Controls.Add(DEmp);
            Name = "frmDatosAleatorio";
            Text = "Empleado con datos aleatorios";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label Nom;
        private Label FNac;
        private TextBox NumBox;
        private TextBox NomBox;
        private DateTimePicker dateFNac;
        private RadioButton MASC;
        private RadioButton FEM;
        private Label Grp;
        private ComboBox GrpSel;
        private Label Sueldo;
        private TextBox Sueldobox;
        private RadioButton SegMed;
        private Button GenNumRand;
    }
}


