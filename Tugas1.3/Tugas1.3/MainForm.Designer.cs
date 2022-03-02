/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/1/2022
 * Time: 10:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas1._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.komList = new System.Windows.Forms.ListBox();
			this.nameText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nama : ";
			// 
			// komList
			// 
			this.komList.FormattingEnabled = true;
			this.komList.Items.AddRange(new object[] {
									"A",
									"B",
									"C"});
			this.komList.Location = new System.Drawing.Point(149, 126);
			this.komList.Name = "komList";
			this.komList.Size = new System.Drawing.Size(71, 17);
			this.komList.TabIndex = 2;
			// 
			// nameText
			// 
			this.nameText.Location = new System.Drawing.Point(149, 97);
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(71, 20);
			this.nameText.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(33, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "KOM :";
			// 
			// textOutput
			// 
			this.textOutput.Location = new System.Drawing.Point(33, 198);
			this.textOutput.Name = "textOutput";
			this.textOutput.Size = new System.Drawing.Size(206, 20);
			this.textOutput.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textOutput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.komList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Tugas1.3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textOutput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameText;
		private System.Windows.Forms.ListBox komList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
