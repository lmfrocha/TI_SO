/*
 * Created by SharpDevelop.
 * User: Lucas Rocha
 * Date: 09/04/2018
 * Time: 09:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;


namespace Calc_polonesa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{			
			txtResult.Text = Polonesa_Reversa.ExpressionCalculate(txtExpressao.Text).ToString();
			txtExpressaoPosfixa.Text = Polonesa_Reversa.ExpressionInfixa(txtExpressao.Text).ToString();
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtExpressao.Clear();
			txtExpressaoPosfixa.Clear();
			txtResult.Clear();
		}
		
		
	}
}
