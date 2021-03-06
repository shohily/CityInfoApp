﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInfoApp
{
    public partial class CityInfo : Form
    {
        public CityInfo()
        {
            InitializeComponent();
        }

        string connectionstring = @"server=RAKIB-PC;database=DBCityInfo;integrated security=true";
        City aCity=new City();
        private bool checkCountry = false, checkCity = false;
        private bool isUpdateMode = false;
        private int cSerialNO;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aCity.cityName = cityNameTextBox.Text;
            aCity.about = aboutTextBox.Text;
            aCity.country = countryTextBox.Text;

            if (isUpdateMode)
            {
                SqlConnection connection = new SqlConnection(connectionstring);

                string query = "UPDATE CityInfo_Table SET About ='" + aCity.about + "', Country ='" + aCity.country + "' WHERE SerialNo = '" + cSerialNO + "'";


                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();



                //4. see result

                if (rowAffected > 0)
                {
                    MessageBox.Show("Updated Successfully!");

                    saveButton.Text = "Save";
                    cSerialNO = 0;
                    isUpdateMode = false;
                    cityNameTextBox.Enabled = true;
                    ShowAllInfo();

                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }

            else
            {
                if (aCity.cityName.Length >= 4)
                {
                    if (IsCityNameExists(aCity.cityName))
                    {
                        MessageBox.Show("City Name Is Already Exists!");
                        return;
                    }
                    SqlConnection aConnection = new SqlConnection(connectionstring);

                    aConnection.Open();

                    string query = "INSERT INTO CityInfo_Table VALUES('" + aCity.cityName + "','" + aCity.about + "','" + aCity.country + "')";

                    SqlCommand command = new SqlCommand(query, aConnection);

                    int rowAffected = command.ExecuteNonQuery();
                    aConnection.Close();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Inserted Successfully!");
                        ShowAllInfo();
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed!");
                    }
                    //cityNameTextBox.Text = "";
                    //aboutTextBox.Text = "";
                    //countryTextBox.Text = "";
                }

                else
                {

                    MessageBox.Show("City Name must be at least 4 character!");
                }
            }
            
        }

        public bool IsCityNameExists(string cityName)
        {
            SqlConnection aConnection = new SqlConnection(connectionstring);

            string query = " SELECT * From CityInfo_Table WHERE CityName= '" + cityName + "'";

            SqlCommand command = new SqlCommand(query, aConnection);
            aConnection.Open();

            bool isCityNameExists = false;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isCityNameExists = true;
                break;
            }

            reader.Close();
            aConnection.Close();
            return isCityNameExists;

        }


        public void ShowAllInfo()
        {
              SqlConnection connection = new SqlConnection(connectionstring);
              string query = "SELECT * FROM CityInfo_Table";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> cityList = new List<City>();
            while (reader.Read())
            {
                City city = new City();
                city.serialNo = int.Parse(reader["SerialNo"].ToString());
                city.cityName = reader["CityName"].ToString();
                city.about = reader["About"].ToString();
                city.country = reader["Country"].ToString();
           
                cityList.Add(city);

            }
            reader.Close();
            connection.Close();
            LoadCityListView(cityList);
        }
        

        public void LoadCityListView(List<City> cities)
        {
            cityListView.Items.Clear();
            int cnt = 1;
            foreach (var city in cities)
            {
                ListViewItem item = new ListViewItem(cnt.ToString());
                item.SubItems.Add(city.cityName);
                item.SubItems.Add(city.about);
                item.SubItems.Add(city.country);
                cityListView.Items.Add(item);
                cnt++;
            }
        }

        private void CityInfo_Load(object sender, EventArgs e)
        {
            ShowAllInfo();
        }

        private void cityListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = cityListView.SelectedItems[0];
            int serialNo = Convert.ToInt16(item.Text.ToString());
            City aCity = GetCityInfoBySerialNo(serialNo);
            if (aCity != null)
            {
                isUpdateMode = true;

                saveButton.Text = "Update";
                cSerialNO = aCity.serialNo;
                cityNameTextBox.Enabled = false;

                cityNameTextBox.Text = aCity.cityName;
                aboutTextBox.Text = aCity.about;
                countryTextBox.Text = aCity.country;
            }


        }

        public City GetCityInfoBySerialNo(int serialNo)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT * FROM CityInfo_Table WHERE SerialNo='"+serialNo+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> cityList = new List<City>();
            while (reader.Read())
            {
                City city = new City();
                city.serialNo = int.Parse(reader["SerialNo"].ToString());
                city.cityName = reader["CityName"].ToString();
                city.about = reader["About"].ToString();
                city.country = reader["Country"].ToString();

                cityList.Add(city);

            }
            reader.Close();
            connection.Close();
            return cityList.FirstOrDefault();
        }

        

        private void cityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkCity = true;
            checkCountry = false;

        }

        private void countryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkCity = false;
            checkCountry = true;

        }

        private void ClearAll()
        {
            searchTextBox.Text = cityNameTextBox.Text = aboutTextBox.Text = countryTextBox.Text = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (checkCity)
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                string query = "SELECT * FROM CityInfo_Table";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<City> cityList = new List<City>();
                while (reader.Read())
                {
                    City city = new City();
                    if (reader[1].ToString().Contains(searchTextBox.Text))
                    {
                        city.cityName = reader[1].ToString();
                        city.about = reader[2].ToString();
                        city.country = reader[3].ToString();
                        cityList.Add(city);
                    }

                }
                reader.Close();
                connection.Close();
                LoadCityListView(cityList);
                ClearAll();
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                string query = "SELECT * FROM CityInfo_Table";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<City> cityList = new List<City>();
                while (reader.Read())
                {
                    City city = new City();
                    if (reader[3].ToString().Contains(searchTextBox.Text))
                    {
                        city.cityName = reader[1].ToString();
                        city.about = reader[2].ToString();
                        city.country = reader[3].ToString();
                        cityList.Add(city);
                    }

                }
                reader.Close();
                connection.Close();
                LoadCityListView(cityList);
                ClearAll();
            }
        }
          

    }
}
