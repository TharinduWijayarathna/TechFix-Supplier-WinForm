using Newtonsoft.Json;
using StoreClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StoreClient
{
    public partial class QuotationForm : Form
    {
        public QuotationForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string url = "https://localhost:7135/api/Quotation/supplier/" + 1;
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();
                var items = readTask.Result;
                dgvItems.DataSource = null;
                dgvItems.DataSource = (new JavaScriptSerializer()).
                                        Deserialize<List<Quotation>>(items);
            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if (c == 0)
            {
                txtID.Text = dgvItems.Rows[r].Cells[2].Value.ToString();
                txtName.Text = dgvItems.Rows[r].Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgvItems.Rows[r].Cells[4].Value);
            }

            //if c == 1 pass the id to the next form
            if (c == 1)
            {
                int id = Convert.ToInt32(dgvItems.Rows[r].Cells[2].Value);
                this.Hide();
                QuotationItemForm form = new QuotationItemForm(id);
                form.ShowDialog();
                this.Close();
            }
        }

        private void QuotationForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7135/api/Quotation";

            using (HttpClient client = new HttpClient())
            {
                Quotation item = new Quotation
                {
                    Name = txtName.Text,
                    Date = dateTimePicker1.Value,
                    SupplierId = 1
                };

                string info = JsonConvert.SerializeObject(item);
                var content = new StringContent(info, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Quotation added successfully");
                        LoadData();
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to add Quotation: {response.StatusCode} - {errorContent}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7135/api/Quotation/" + txtID.Text;

            using (HttpClient client = new HttpClient())
            {
                Quotation item = new Quotation
                {
                    Name = txtName.Text,
                    Date = dateTimePicker1.Value,
                    SupplierId = 1
                };

                string info = JsonConvert.SerializeObject(item);
                var content = new StringContent(info, Encoding.UTF8, "application/json");

                try
                {
                    var response = client.PutAsync(url, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Quotation updated successfully");
                        LoadData();
                    }
                    else
                    {
                        var errorContent = response.Content.ReadAsStringAsync().Result;
                        MessageBox.Show($"Failed to update Quotation: {response.StatusCode} - {errorContent}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7135/api/Quotation/" + txtID.Text;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.DeleteAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Quotation deleted successfully");
                        LoadData();
                    }
                    else
                    {
                        var errorContent = response.Content.ReadAsStringAsync().Result;
                        MessageBox.Show($"Failed to delete Quotation: {response.StatusCode} - {errorContent}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
