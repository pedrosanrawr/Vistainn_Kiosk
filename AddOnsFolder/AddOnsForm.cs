using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistainn_Kiosk
{
    public partial class AddOnsForm : Form
    {
        Database database = new Database();
        private mainPage parentPage;

        private List<AddOnItem> addOnItems = new List<AddOnItem>();

        public AddOnsForm(mainPage parent)
        {
            InitializeComponent();
            this.parentPage = parent;
        }

        // back button - click
        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new SelectRoomForm(parentPage));
        }

        // next button - click
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Validate the Add-ons selection
            bool canProceed = true;
            foreach (var item in addOnItems)
            {
                if (item.IsSelected && item.Quantity <= 0)
                {
                    canProceed = false;
                    break;
                }
            }

            if (!canProceed)
            {
                MessageBox.Show("Please enter a quantity for all selected add-ons before proceeding.",
                    "Quantity Required", MessageBoxButtons.OK);
                return;
            }

            // If validation passes, proceed to the next form
            parentPage.loadForm(new CustomerInfoForm(parentPage));
        }

        // add ons form - load
        private void AddOnsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateTotalPriceLabel();
        }

        // load data - method
        public void LoadData()
        {
            try
            {
                string query = "SELECT AoName, AoPrice FROM AddOns";

                using (MySqlConnection con = new MySqlConnection(database.connectionString))
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    aoTable.DataSource = dt;

                    // Now create AddOnItems from the loaded data
                    addOnItems.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        string name = row["AoName"].ToString();
                        double price = Convert.ToDouble(row["AoPrice"]);
                        // Initialize with a quantity of 0, not selected by default
                        addOnItems.Add(new AddOnItem(name, price, 0, false));
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aoTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateAddOnItem(e.RowIndex);
                UpdateTotalPriceLabel();
            }
        }

        private void UpdateAddOnItem(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= addOnItems.Count)
                return;

            var item = addOnItems[rowIndex];

            var selectCell = aoTable.Rows[rowIndex].Cells["Select"];
            var quantityCell = aoTable.Rows[rowIndex].Cells["AoQty"];

            item.IsSelected = Convert.ToBoolean(selectCell.Value);

            if (!item.IsSelected)
            {
                quantityCell.Value = null;
                item.Quantity = 0;
            }
            else
            {
                item.Quantity = quantityCell.Value != null ? Convert.ToInt32(quantityCell.Value) : 0;
            }
        }


        private void UpdateTotalPriceLabel()
        {
            double totalPrice = 0;

            foreach (var item in addOnItems)
            {
                totalPrice += item.GetTotalPrice();
            }

            totalPriceLabel.Text = $"TOTAL AMOUNT OF ADD-ONS: ₱{totalPrice:F2}";
        }

        private void aoTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (aoTable.IsCurrentCellDirty)
            {
                aoTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
                UpdateTotalPriceLabel();
            }
        }
    }
    public class AddOnItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsSelected { get; set; }

        public AddOnItem(string name, double price, int quantity, bool isSelected)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            IsSelected = isSelected;
        }

        public double GetTotalPrice()
        {
            return IsSelected ? Quantity * Price : 0;
        }
    }
}
