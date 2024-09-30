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

namespace StoreClient
{
    public partial class QuotationItemForm : Form
    {
        int quotationId;
        public QuotationItemForm()
        {
            InitializeComponent();
        }

        public QuotationItemForm(int quotationId)
        {
            InitializeComponent();
            LoadData();
            this.quotationId = quotationId;
        }

        private void LoadData()
        {
            string url = "https://localhost:7135/api/QuotationItem/quotation/"+ quotationId;
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
                                        Deserialize<List<QuotationItem>>(items);
            }
        }

        private void QuotationItemForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if (c == 0)
            {
                txtID.Text = dgvItems.Rows[r].Cells[1].Value.ToString();
                txtName.Text = dgvItems.Rows[r].Cells[2].Value.ToString();
                txtPrice.Text = dgvItems.Rows[r].Cells[3].Value.ToString();
                txtStock.Text = dgvItems.Rows[r].Cells[4].Value.ToString();
                txtDes.Text = dgvItems.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            QuotationForm Form = new QuotationForm();
            Form.ShowDialog();
            this.Close();

        }

        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
            string url = "https://localhost:7135/api/QuotationItem";

            using (HttpClient client = new HttpClient())
            {
                QuotationItem item = new QuotationItem
                {
                    Name = txtName.Text,
                    QuotationId = quotationId,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Quantity = Convert.ToInt32(txtStock.Text),
                    Description = txtDes.Text
                };

                string info = JsonConvert.SerializeObject(item);
                var content = new StringContent(info, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Quotation Item added successfully");
                        LoadData();
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to add Quotation Item: {response.StatusCode} - {errorContent}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string url = "https://localhost:7135/api/QuotationItem/" + txtID.Text;
            HttpClient client = new HttpClient();

            QuotationItem item = new QuotationItem
            {
                Id = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                QuotationId = quotationId,
                Price = Convert.ToDecimal(txtPrice.Text),
                Quantity = Convert.ToInt32(txtStock.Text),
                Description = txtDes.Text
            };

            string info = JsonConvert.SerializeObject(item);
            var content = new StringContent(info, Encoding.UTF8, "application/json");

            var response = client.PutAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Quotation Item updated successfully");
                LoadData();
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Failed to update Quotation Item: {response.StatusCode} - {errorContent}");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string url = "https://localhost:7135/api/QuotationItem/" + txtID.Text;
            HttpClient client = new HttpClient();

            var response = client.DeleteAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Quotation Item deleted successfully");
                LoadData();
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Failed to delete Quotation Item: {response.StatusCode} - {errorContent}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuotationForm form = new QuotationForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
