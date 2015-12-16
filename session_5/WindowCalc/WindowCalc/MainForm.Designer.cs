/*
 * Created by SharpDevelop.
 * User: Hemanth Sai
 * Date: 12/10/2015
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WindowCalc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnOne;
		private System.Windows.Forms.TextBox txtDisplay;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.Button btnMul;
		private System.Windows.Forms.Button btnZero;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnEqual;
		private System.Windows.Forms.Button btnNine;
		private System.Windows.Forms.Button btnEight;
		private System.Windows.Forms.Button btnSeven;
		private System.Windows.Forms.Button btnSix;
		private System.Windows.Forms.Button btnfive;
		private System.Windows.Forms.Button btnFour;
		private System.Windows.Forms.Button btnThree;
		private System.Windows.Forms.Button btnTwo;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnC;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnDot = new System.Windows.Forms.Button();
			this.btnMul = new System.Windows.Forms.Button();
			this.btnZero = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnEqual = new System.Windows.Forms.Button();
			this.btnNine = new System.Windows.Forms.Button();
			this.btnEight = new System.Windows.Forms.Button();
			this.btnSeven = new System.Windows.Forms.Button();
			this.btnSix = new System.Windows.Forms.Button();
			this.btnfive = new System.Windows.Forms.Button();
			this.btnFour = new System.Windows.Forms.Button();
			this.btnThree = new System.Windows.Forms.Button();
			this.btnTwo = new System.Windows.Forms.Button();
			this.btnOne = new System.Windows.Forms.Button();
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnC);
			this.panel1.Controls.Add(this.btnDot);
			this.panel1.Controls.Add(this.btnMul);
			this.panel1.Controls.Add(this.btnZero);
			this.panel1.Controls.Add(this.btnDiv);
			this.panel1.Controls.Add(this.btnMinus);
			this.panel1.Controls.Add(this.btnPlus);
			this.panel1.Controls.Add(this.btnEqual);
			this.panel1.Controls.Add(this.btnNine);
			this.panel1.Controls.Add(this.btnEight);
			this.panel1.Controls.Add(this.btnSeven);
			this.panel1.Controls.Add(this.btnSix);
			this.panel1.Controls.Add(this.btnfive);
			this.panel1.Controls.Add(this.btnFour);
			this.panel1.Controls.Add(this.btnThree);
			this.panel1.Controls.Add(this.btnTwo);
			this.panel1.Controls.Add(this.btnOne);
			this.panel1.Controls.Add(this.txtDisplay);
			this.panel1.Location = new System.Drawing.Point(8, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 342);
			this.panel1.TabIndex = 0;
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(125, 85);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(83, 35);
			this.btnClear.TabIndex = 19;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// btnC
			// 
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnC.Location = new System.Drawing.Point(23, 85);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(88, 35);
			this.btnC.TabIndex = 18;
			this.btnC.Text = "CE";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.BtnClearCE);
			// 
			// btnDot
			// 
			this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDot.Location = new System.Drawing.Point(226, 297);
			this.btnDot.Name = "btnDot";
			this.btnDot.Size = new System.Drawing.Size(50, 35);
			this.btnDot.TabIndex = 16;
			this.btnDot.Text = ".";
			this.btnDot.UseVisualStyleBackColor = true;
			this.btnDot.Click += new System.EventHandler(this.BtnDotClick);
			// 
			// btnMul
			// 
			this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMul.Location = new System.Drawing.Point(158, 297);
			this.btnMul.Name = "btnMul";
			this.btnMul.Size = new System.Drawing.Size(50, 35);
			this.btnMul.TabIndex = 15;
			this.btnMul.Text = "*";
			this.btnMul.UseVisualStyleBackColor = true;
			this.btnMul.Click += new System.EventHandler(this.BtnOperatorClick);
			// 
			// btnZero
			// 
			this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnZero.Location = new System.Drawing.Point(91, 297);
			this.btnZero.Name = "btnZero";
			this.btnZero.Size = new System.Drawing.Size(50, 35);
			this.btnZero.TabIndex = 14;
			this.btnZero.Text = "0";
			this.btnZero.UseVisualStyleBackColor = true;
			this.btnZero.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnDiv
			// 
			this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.Location = new System.Drawing.Point(23, 297);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(50, 35);
			this.btnDiv.TabIndex = 13;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.BtnOperatorClick);
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinus.Location = new System.Drawing.Point(226, 249);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(50, 35);
			this.btnMinus.TabIndex = 12;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.BtnOperatorClick);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(226, 192);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(50, 35);
			this.btnPlus.TabIndex = 11;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.BtnOperatorClick);
			// 
			// btnEqual
			// 
			this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEqual.Location = new System.Drawing.Point(226, 85);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(50, 85);
			this.btnEqual.TabIndex = 10;
			this.btnEqual.Text = "=";
			this.btnEqual.UseVisualStyleBackColor = true;
			this.btnEqual.Click += new System.EventHandler(this.BtnEqualClick);
			// 
			// btnNine
			// 
			this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNine.Location = new System.Drawing.Point(158, 249);
			this.btnNine.Name = "btnNine";
			this.btnNine.Size = new System.Drawing.Size(50, 35);
			this.btnNine.TabIndex = 9;
			this.btnNine.Text = "9";
			this.btnNine.UseVisualStyleBackColor = true;
			this.btnNine.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnEight
			// 
			this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEight.Location = new System.Drawing.Point(91, 249);
			this.btnEight.Name = "btnEight";
			this.btnEight.Size = new System.Drawing.Size(50, 35);
			this.btnEight.TabIndex = 8;
			this.btnEight.Text = "8";
			this.btnEight.UseVisualStyleBackColor = true;
			this.btnEight.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnSeven
			// 
			this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeven.Location = new System.Drawing.Point(23, 249);
			this.btnSeven.Name = "btnSeven";
			this.btnSeven.Size = new System.Drawing.Size(50, 35);
			this.btnSeven.TabIndex = 7;
			this.btnSeven.Text = "7";
			this.btnSeven.UseVisualStyleBackColor = true;
			this.btnSeven.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnSix
			// 
			this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSix.Location = new System.Drawing.Point(158, 192);
			this.btnSix.Name = "btnSix";
			this.btnSix.Size = new System.Drawing.Size(50, 35);
			this.btnSix.TabIndex = 6;
			this.btnSix.Text = "6";
			this.btnSix.UseVisualStyleBackColor = true;
			this.btnSix.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnfive
			// 
			this.btnfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnfive.Location = new System.Drawing.Point(91, 192);
			this.btnfive.Name = "btnfive";
			this.btnfive.Size = new System.Drawing.Size(50, 35);
			this.btnfive.TabIndex = 5;
			this.btnfive.Text = "5";
			this.btnfive.UseVisualStyleBackColor = true;
			this.btnfive.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnFour
			// 
			this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFour.Location = new System.Drawing.Point(23, 192);
			this.btnFour.Name = "btnFour";
			this.btnFour.Size = new System.Drawing.Size(50, 35);
			this.btnFour.TabIndex = 4;
			this.btnFour.Text = "4";
			this.btnFour.UseVisualStyleBackColor = true;
			this.btnFour.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnThree
			// 
			this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThree.Location = new System.Drawing.Point(158, 135);
			this.btnThree.Name = "btnThree";
			this.btnThree.Size = new System.Drawing.Size(50, 35);
			this.btnThree.TabIndex = 3;
			this.btnThree.Text = "3";
			this.btnThree.UseVisualStyleBackColor = true;
			this.btnThree.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnTwo
			// 
			this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTwo.Location = new System.Drawing.Point(91, 133);
			this.btnTwo.Name = "btnTwo";
			this.btnTwo.Size = new System.Drawing.Size(50, 35);
			this.btnTwo.TabIndex = 2;
			this.btnTwo.Text = "2";
			this.btnTwo.UseVisualStyleBackColor = true;
			this.btnTwo.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// btnOne
			// 
			this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOne.Location = new System.Drawing.Point(23, 133);
			this.btnOne.Name = "btnOne";
			this.btnOne.Size = new System.Drawing.Size(50, 35);
			this.btnOne.TabIndex = 1;
			this.btnOne.Text = "1";
			this.btnOne.UseVisualStyleBackColor = true;
			this.btnOne.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// txtDisplay
			// 
			this.txtDisplay.Enabled = false;
			this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisplay.ForeColor = System.Drawing.SystemColors.Info;
			this.txtDisplay.Location = new System.Drawing.Point(1, 0);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(295, 67);
			this.txtDisplay.TabIndex = 0;
			this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 364);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
