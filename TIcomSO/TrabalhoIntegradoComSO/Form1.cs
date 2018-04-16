using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrabalhoIntegradoComSO.Package;
using TrabalhoIntegradoComSO.Structs;

namespace TrabalhoIntegradoComSO
{
    public partial class Form1 : Form
    {
         Fila p1, p2, p3, p4, p5;
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine("Fila de prioridade 1: " + p1.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 2: " + p2.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 3: " + p3.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 4: " + p4.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 5: " + p5.quantidade + " Processos");
            MessageBox.Show(aux.ToString());
            
            Processo temp = new Processo(0, null, 0, 0, 0);

            string prioridade = "";

            do
            {

                if (p1.estaVazia()==false)
                {
                    prioridade = "p1";

                }
                if ((p2.estaVazia() && p1.estaVazia()) ==false)
                {
                    prioridade = "p3";

                }
                if ((p2.estaVazia() && p1.estaVazia()&& p3.estaVazia())==false)
                {
                    prioridade = "p4";

                }
                if ((p2.estaVazia() && p1.estaVazia() && p3.estaVazia() && p4.estaVazia())==false)
                {
                    prioridade = "p5";

                }
                switch (prioridade)
                {
                    case "p1":
                        temp = (Processo)p1.desenfileirar();
                        timer1.Enabled = true;
                        timer1.Start();
                        while (timer1.Interval < temp.TimeExec)
                        {
                        }
                        timer1.Stop();
                        timer1.Enabled = false;
                        temp.Ciclos -= 1;
                        if (temp.Ciclos > 0)
                        {
                            p1.enfileirar(temp);
                        }
                        
                        break;
                    case "p2":
                        temp = (Processo)p2.desenfileirar();
                        timer1.Enabled = true;
                        timer1.Start();
                        while (timer1.Interval < temp.TimeExec)
                        {
                        }
                        timer1.Stop();
                        timer1.Enabled = false;
                        temp.Ciclos -= 1;
                        if (temp.Ciclos > 0)
                        {
                            p2.enfileirar(temp);
                        }
                        break;
                    case "p3":
                        temp = (Processo)p3.desenfileirar();
                        timer1.Enabled = true;
                        timer1.Start();
                        while (timer1.Interval < temp.TimeExec)
                        {
                        }
                        timer1.Stop();
                        timer1.Enabled = false;
                        temp.Ciclos -= 1;
                        if (temp.Ciclos > 0)
                        {
                            p3.enfileirar(temp);
                        }
                        break;
                    case "p4":
                        temp = (Processo)p4.desenfileirar();
                        timer1.Enabled = true;
                        timer1.Start();
                        while (timer1.Interval < temp.TimeExec)
                        {
                        }
                        timer1.Stop();
                        timer1.Enabled = false;
                        temp.Ciclos -= 1;
                        if (temp.Ciclos > 0)
                        {
                            p4.enfileirar(temp);
                        }
                        break;
                    case "p5":
                        temp = (Processo)p5.desenfileirar();
                        timer1.Enabled = true;
                        timer1.Start();
                        while (timer1.Interval < temp.TimeExec)
                        {
                        }
                        timer1.Stop();
                        timer1.Enabled = false;
                        temp.Ciclos -= 1;
                        if (temp.Ciclos > 0)
                        {
                            p5.enfileirar(temp);
                        }
                        break;
                    default:
                        break;
                }



            } while (p1.estaVazia() || p2.estaVazia() || p3.estaVazia() || p4.estaVazia() || p5.estaVazia() != true);

            aux = new StringBuilder();
            aux.AppendLine("Fila de prioridade 1: " + p1.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 2: " + p2.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 3: " + p3.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 4: " + p4.quantidade + " Processos");
            aux.AppendLine("Fila de prioridade 5: " + p5.quantidade + " Processos");
            MessageBox.Show(aux.ToString());

        }
        private void btnLoadLista_Click(object sender, EventArgs e)
        {
            p1 = new Fila();
            p2 = new Fila();
            p3 = new Fila();
            p4 = new Fila();
            p5 = new Fila();

            LerArquivo.Ler(p1,p2,p3,p4,p5);
                       
            //StringBuilder aux = new StringBuilder();
            //aux.AppendLine("Fila de prioridade 1: " + p1.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 2: " + p2.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 3: " + p3.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 4: " + p4.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 5: " + p5.quantidade + " Processos");
            //MessageBox.Show(aux.ToString());
            
            //Processo ze = new Processo(0, null, 0, 0, 0);
            //ze = (Processo)  p1.desenfileirar();
            //p3.desenfileirar();
            //p5.desenfileirar();
            //aux = new StringBuilder();
            //aux.AppendLine("Fila de prioridade 1: " + p1.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 2: " + p2.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 3: " + p3.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 4: " + p4.quantidade + " Processos");
            //aux.AppendLine("Fila de prioridade 5: " + p5.quantidade + " Processos");
            //MessageBox.Show(aux.ToString());
            //if (p3.estaVazia())
            //{
            //    MessageBox.Show("Lista 3 vazia");
            //}
            
        }
    }
}
