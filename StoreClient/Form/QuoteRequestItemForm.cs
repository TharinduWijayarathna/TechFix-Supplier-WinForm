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
    public partial class QuoteRequestItemForm : Form
    {
        public int QuoteRequestId { get; set; }
        public QuoteRequestItemForm()
        {
            InitializeComponent();
        }

        public QuoteRequestItemForm(int quoteRequestId)
        {
            InitializeComponent();
            QuoteRequestId = quoteRequestId;
        }

        private void LoadData()
        {
            string url = "https://localhost:7135/api/QuoteRequestItem/quote/" + QuoteRequestId;
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
                                        Deserialize<List<QuoteRequestItem>>(items);
            }
        }

        private void QuoteRequestItemForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuoteRequestForm quoteRequestForm = new QuoteRequestForm();
            quoteRequestForm.ShowDialog();
            this.Close();
        }
    }
}
