using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Josnell Tejeda Sicart 2022-1145  (Emergencia)
namespace _911
{
    public partial class Form1 : Form
    {
        private int currentQuestion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayQuestion(currentQuestion);
        }

        private void DisplayQuestion(int questionNumber)
        {
            if (questionNumber == 0)
            {
                lblQuestion.Text = "¿Que edad tienes?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "10-20", "21-40", "41-o mas" });
            }
            if (questionNumber == 1)
            {
                lblQuestion.Text = "¿Cuál es el grado de fiebre?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Normal", "Alto", "Muy Alto" });
            }
            else if (questionNumber == 2)
            {
                lblQuestion.Text = "¿Tienes dificultad para respirar Pichardo?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí","A veces", "No" });
            }
            else if (questionNumber == 3)
            {
                lblQuestion.Text = "¿Tienes dolor en el pecho Pichardo?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí", "No" });
            }
            else if (questionNumber == 4)
            {
                lblQuestion.Text = "¿Sientes mareos o debilidad?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí","Continuo mas de 1 hora", "No" });
            }
            else if (questionNumber == 5)
            {
                lblQuestion.Text = "¿Tienes dificultad para hablar?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí", "No" });
                btnNext.Text = "Evaluar";
            }
            else if (questionNumber == 6)
            {
                EvaluateEmergency();
            }
        }
    
            
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string selectedAnswer = cmbAnswer.SelectedItem as string;

            if (currentQuestion <= 5)
            {
                ProcessAnswer(currentQuestion, selectedAnswer);
                currentQuestion++;
                DisplayQuestion(currentQuestion);
            }
        }
        //  para cada respuesta individualmente
        private void ProcessAnswer(int questionNumber, string answer)
        {
            if (questionNumber == 1)
            {
                if (answer == "Normal")
                {
                    MessageBox.Show("Tu fiebre es normal. Descansa y mantente hidratado.");
                }
                else if (answer == "Alto")
                {
                    MessageBox.Show("Tienes fiebre alta. Toma medicamentos para bajar la fiebre y descansa.");
                }
                else if (answer == "Muy Alto")
                {
                    MessageBox.Show("Tienes fiebre muy alta. Busca atención médica de inmediato.");
                }
            }
            else if (questionNumber == 2)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Tienes dificultad para respirar. Busca atención médica de inmediato y que le recomienden un ihnalador o respirador, dependiendo sus resultados.");
                }
                if (answer == "A veces")
                {
                    MessageBox.Show("A veces tienes dificultad para respirar. Haga rehabilitacion pulmunar y terapia fisica.");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("No tienes dificultad para respirar. Descansa y monitorea tus síntomas.");
                }
            }
            else if (questionNumber == 3)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Sientes dolor en el pecho. Busca atención médica de inmediato (Si el dolor esta relacionado con el corazon problabemente le indiquen aspirina) para prevenir los ataque cardiacos..");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("No sientes dolor en el pecho. Continúa monitoreando tus síntomas.");
                }
            }
            else if (questionNumber == 4)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Sientes mareos o debilidad. Descansa y mantente hidratado y reduzca o interrumpa la dosis de cualquie medicamento causal o cambiar.");
                }
                else if (answer == "Continuo mas de 1 hora")
                {
                    MessageBox.Show("sientes mareos o debilidad. Busca atención médica de inmediato .");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("No sientes mareos o debilidad. Continúa monitoreando tus síntomas.");
                }
            }
            else if (questionNumber == 5)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Tienes dificultad para hablar. Busca atención médica de inmediato, es posible que te den terapia del habla y el lenguaje.");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("No tienes dificultad para hablar. Descansa y mantente tranquilo.");
                }
            } 
        }

        private void EvaluateEmergency()
        {
            // Realiza la evaluación final de las respuestas y presenta un procedimiento
            MessageBox.Show("¡Emergencia evaluada! Sigue las recomendaciones dadas.");
            this.Close();
        }
    }
}
    
        
