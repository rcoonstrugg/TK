using System;

namespace WindowsFormsAppLibraryProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Genre = new System.Windows.Forms.ComboBox();
			this.Author = new System.Windows.Forms.ComboBox();
			this.Edition = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.login = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Genre
			// 
			this.Genre.FormattingEnabled = true;
			this.Genre.Location = new System.Drawing.Point(26, 86);
			this.Genre.Name = "Genre";
			this.Genre.Size = new System.Drawing.Size(94, 28);
			this.Genre.TabIndex = 0;
			this.Genre.Text = "Genre";
			this.Genre.SelectedIndexChanged += new System.EventHandler(this.Genre_SelectedIndexChanged);
			// 
			// Author
			// 
			this.Author.FormattingEnabled = true;
			this.Author.Location = new System.Drawing.Point(139, 86);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(94, 28);
			this.Author.TabIndex = 1;
			this.Author.Text = "Author";
			this.Author.SelectedIndexChanged += new System.EventHandler(this.Author_SelectedIndexChanged);
			// 
			// Edition
			// 
			this.Edition.FormattingEnabled = true;
			this.Edition.Location = new System.Drawing.Point(252, 86);
			this.Edition.Name = "Edition";
			this.Edition.Size = new System.Drawing.Size(94, 28);
			this.Edition.TabIndex = 2;
			this.Edition.Text = "Edition";
			this.Edition.SelectedIndexChanged += new System.EventHandler(this.Edition_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(26, 128);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(322, 329);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(28, 15);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(92, 29);
			this.login.TabIndex = 4;
			this.login.Text = "Log in";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(254, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 28);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add book";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(139, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(94, 26);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "Username";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(254, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(92, 26);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "Password";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(385, 469);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.login);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Edition);
			this.Controls.Add(this.Author);
			this.Controls.Add(this.Genre);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox Genre;
		private System.Windows.Forms.ComboBox Author;
		private System.Windows.Forms.ComboBox Edition;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button login;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}

