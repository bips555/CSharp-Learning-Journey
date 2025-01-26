using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_Zoo_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqlConnection connection;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                string connectionString = ConfigurationManager.ConnectionStrings["WPF_Zoo_Manager.Properties.Settings.BipsDBConnectionString"].ConnectionString;
                connection = new SqlConnection(connectionString);
                ShowZoos();
                ShowAnimals();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void ShowZoos()
        {
            string query = "select * from Zoo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            using (sqlDataAdapter)
            {
                DataTable zooTable = new DataTable();
                sqlDataAdapter.Fill(zooTable);
                zooList.DisplayMemberPath = "Location";
                zooList.SelectedValuePath = "Id";
                zooList.ItemsSource = zooTable.DefaultView;
            }
            

        }
        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "select * from Animal a inner join ZooAnimal za on a.Id = za.AnimalId where za.ZooId = @ZooId";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                using (sqlDataAdapter)
                {
                    command.Parameters.AddWithValue("@ZooId", zooList.SelectedValue);
                    DataTable associatedAnimalTable = new DataTable();
                    sqlDataAdapter.Fill(associatedAnimalTable);
                    associatedAnimalList.DisplayMemberPath = "Name";
                    associatedAnimalList.SelectedValuePath = "Id";
                    associatedAnimalList.ItemsSource = associatedAnimalTable.DefaultView;
                }
            }
            catch (Exception)
            {
                /* MessageBox.Show(ex.Message);*/
            }

        }
        private void ZooList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }
        private void AnimalList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            ShowSelectedAnimalInTextBox();
        }
        private void ShowAnimals()
        {
            try
            {
                string query = "select * from Animal";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                using (da)
                {
                    DataTable animalTable = new DataTable();
                    da.Fill(animalTable);
                    animalList.DisplayMemberPath = "Name";
                    animalList.SelectedValuePath = "Id";
                    animalList.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteZoo_CLick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where Id = @ZooId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@ZooId", zooList.SelectedValue);
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowZoos();
            }
        }


        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo Values (@Location)";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Location", AddText.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowZoos();
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into ZooAnimal Values (@ZooId,@AnimalId)";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@Zooid", zooList.SelectedValue);
                command.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue);
                command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowAssociatedAnimals();
            }
        }
        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where Id = @AnimalId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue);
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowAnimals();
            }
        }
        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal Values (@Name)";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Name", AddText.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowAnimals();
            }

        }
        private void RemoveAnimalFromAssociatedZoo(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from ZooAnimal where  AnimalId = @AnimalId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@AnimalId", associatedAnimalList.SelectedValue);
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowAssociatedAnimals();
            }

        }
        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string query = "select Location from Zoo where Id = @ZooId";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                using (da)
                {


                    command.Parameters.AddWithValue("@ZooId", zooList.SelectedValue);
                    DataTable zooDataTable = new DataTable();
                    da.Fill(zooDataTable);
                    AddText.Text = zooDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch(Exception)
            {
               // MessageBox.Show(ex.Message);
            }

          
        }
        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string query = "select Name from Animal where Id = @AnimalId";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                using (da)
                {


                    command.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue);
                    DataTable animalDataTable = new DataTable();
                    da.Fill(animalDataTable);
                    AddText.Text = animalDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception)
            {
               // MessageBox.Show(ex.Message);
            }


        }

        private void UpdateZoo_CLick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Zoo Set Location = @Location where Id = @ZooId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@Location", AddText.Text);
                command.Parameters.AddWithValue("@ZooId", zooList.SelectedValue);
                command.ExecuteScalar();
            }
            catch (Exception)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowZoos();
            }
        }
        private void UpdateAnimal_CLick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal Set Name = @Name where Id = @AnimalId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@Name", AddText.Text);
                command.Parameters.AddWithValue("@AnimalId", animalList.SelectedValue);
                command.ExecuteScalar();
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ShowAnimals();
            }
        }
    }
}