/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/1/2022
 * Time: 10:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas1._
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
			komList.SelectedIndex = 0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String nameInput = nameText.Text;
				
			textOutput.Text = "Hello, "+nameInput+" from Class "+komList.SelectedItem.ToString()+". Nice to meet you.";
		}
	}
}
