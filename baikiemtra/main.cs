using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baikiemtra
{
    public partial class main : Form
    {
        private List<Product> productList = new List<Product>();
        private Shoppingcart cart = new Shoppingcart();
        public main()
        {
            InitializeComponent();
            LoadProducts();
            DisplayProducts();
            UpdateCartDisplay();
        }

        private void LoadProducts()
        {
            productList.Add(new Product("Asus Vivobook ", 100, 10, Properties.Resources.asus_vivobook));
            productList.Add(new Product("Dell Inspiron 15 3520", 250, 15, Properties.Resources.dell_inspiron_15_3520));
            productList.Add(new Product("HP 15 ", 150, 17, Properties.Resources.hp_15));
            productList.Add(new Product("Lenovo Ideapad Slim 3", 300, 16, Properties.Resources.lenovo_ideapad_slim_3));
            productList.Add(new Product("Acer Aspire 3", 400, 18, Properties.Resources.acer_aspire_a315));
        }

        private void DisplayProducts()
        {
            LstProduct.Items.Clear();
            foreach (var product in productList)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Quantity.ToString());
                item.Tag = product;
                LstProduct.Items.Add(item);
            }
        }

        private void UpdateCartDisplay()
        {
            LstCart.Items.Clear();
            foreach (var product in cart.Products)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add((product.Price * product.Quantity).ToString("C"));
                LstCart.Items.Add(item);
            }
            lblTotalAmount1.Text = $"Tổng giá trị: {cart.GetTotalAmount():C}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (LstProduct.SelectedItems.Count > 0)
            {
                var selectedProduct = (Product)LstProduct.SelectedItems[0].Tag;
                cart.AddProduct(selectedProduct);
                UpdateCartDisplay();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (LstCart.SelectedItems.Count > 0)
            {
                var selectedProduct = (Product)LstCart.SelectedItems[0].Tag;
                cart.RemoveProduct(selectedProduct);
                UpdateCartDisplay();
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            if (cart.Products.Count > 0)
            {
                MessageBox.Show("Đơn hàng đã được thanh toán thành công!", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cart.Clear();
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
