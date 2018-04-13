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

        private void btnLoadLista_Click(object sender, EventArgs e)
        {

            p1 = new Fila();
            p2 = new Fila();
            p3 = new Fila();
            p4 = new Fila();
            p5 = new Fila();

            //&& p2.estaVazia() && p3.estaVazia() && p4.estaVazia() && p5.estaVazia()
            


            LerArquivo.Ler(p1,p2,p3,p4,p5);



            for (int i = 0; i < p1.quantidade; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = 
                item.SubItems.Add(p1.quantidade.ToString());
                
                
                listView1.Items.Add(item);
                textBox1.Text = p1.totalLista().ToString();
                p1.prim = p1.prim.prox;
            }
        }
    }
}
