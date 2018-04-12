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

            LerArquivo.Ler(p1,p2,p3,p4,p5);

        }
    }
}
