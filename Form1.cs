using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using MySqlConnector;

namespace WindowsFormsAppLibraryProject
{
	public partial class Form1 : Form
	{
		string connectionString = "Server=localhost;Database=Library;User=root;Password=cokolwiek;";
		MySqlConnection connection;

		private string userRole;
		private Button addButton;
		private TextBox usernameTextBox;
		private TextBox passwordTextBox;

		public Form1()
		{
			InitializeComponent();
			this.Load += new EventHandler(Form1_Load);
			addButton.Click += new EventHandler(button1_Click);
			usernameTextBox.TextChanged += new EventHandler(textBox1_TextChanged);
			passwordTextBox.TextChanged += new EventHandler(textBox2_TextChanged);

			InitializeDatabaseConnection();
		}

		private bool comboBoxesInitialized = false;

		private void Form1_Load(object sender, EventArgs e)
		{
			if (!comboBoxesInitialized)
			{
				Genre.Items.Add("Science Fiction");
				Genre.Items.Add("Biography");
				Genre.Items.Add("Fantasy");

				comboBoxesInitialized = true;
			}
		}

		private void Genre_SelectedIndexChanged(object sender, EventArgs e)
		{
			Author.Items.Clear();
			Edition.Items.Clear();

			string selectedGenre = Genre.SelectedItem.ToString();

			if (selectedGenre == "Science Fiction")
			{
				Author.Items.Add("Isaac Asimov");
				Author.Items.Add("Peter Watts");
			}
			else if (selectedGenre == "Biography")
			{
				Author.Items.Add("Slash");
			}
			else if (selectedGenre == "Fantasy")
			{
				Author.Items.Add("Terry Pratchett");
			}
		}

		private void Author_SelectedIndexChanged(object sender, EventArgs e)
		{
			Edition.Items.Clear();

			string selectedAuthor = Author.SelectedItem.ToString();

			if (selectedAuthor == "Isaac Asimov")
			{
				Edition.Items.Add("Foundation, Edition 1");
				Edition.Items.Add("I, Robot, Edition 1");
			}
			else if (selectedAuthor == "Peter Watts")
			{
				Edition.Items.Add("Blindsight, Edition 1");
			}
			else if (selectedAuthor == "Slash")
			{
				Edition.Items.Add("Slash, Edition 1");
			}
			else if (selectedAuthor == "Terry Pratchett")
			{
				Edition.Items.Add("Mort, Edition 2");
			}
		}

		private void Edition_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedEdition = Edition.SelectedItem?.ToString();

			pictureBox1.Image = null;

			Dictionary<string, string> bookCovers = new Dictionary<string, string>
			{
				{ "Foundation, Edition 1", @"D:\Visual studio projects\WindowsAppLibraryProject\foundation.jpg" },
				{ "I, Robot, Edition 1", @"D:\Visual studio projects\WindowsAppLibraryProject\irobot.jpg" },
				{ "Slash, Edition 1", @"D:\Visual studio projects\WindowsAppLibraryProject\slash.jpg" },
				{ "Blindsight, Edition 1", @"D:\Visual studio projects\WindowsAppLibraryProject\blinsight.jpg" },
				{ "Mort, Edition 2", @"D:\Visual studio projects\WindowsAppLibraryProject\mort.jpg" },
			};

			if (bookCovers.ContainsKey(selectedEdition))
			{
				string imagePath = bookCovers[selectedEdition];

				try
				{
					pictureBox1.Image = Image.FromFile(imagePath);

					pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				}
				catch (System.IO.FileNotFoundException ex)
				{
					MessageBox.Show($"Image not found: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void InitializeDatabaseConnection() //Connect to database
		{
			connection = new MySqlConnection(connectionString);
			try
			{
				connection.Open();
				MessageBox.Show("Connected to MySQL database.");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string username = usernameTextBox.Text;
			string password = passwordTextBox.Text;

			if (IsUserValid(username, password))
			{

				userRole = GetUserRole(username);
				if (userRole == "Employee")
				{
					addButton.Enabled = true;
				}
				else
				{
					addButton.Enabled = false;
				}
			}
			else
			{
				MessageBox.Show("Invalid username or password. Please try again.");
			}
		}

		private bool IsUserValid(string username, string password)
		{
			return username == "admin" && password == "admin";
		}

		private string GetUserRole(string username)
		{
			return "Employee";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
