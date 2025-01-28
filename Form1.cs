using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Machine
{
    public partial class Form1 : Form
    {
        CoffeeMachine coffeeMachine;

        public Form1()
        {
            InitializeComponent();
            coffeeMachine = new CoffeeMachine();

            // Add options to ComboBox
            cmbDrinkOptions.Items.Add("Black Coffee");
            cmbDrinkOptions.Items.Add("Mocha");
            cmbDrinkOptions.Items.Add("Latte");
            cmbDrinkOptions.Items.Add("Chocolate");
            cmbDrinkOptions.SelectedIndex = 0; // Default selection

            // Style buttons
            btnCheckStock.BackColor = Color.DodgerBlue;
            btnCheckStock.ForeColor = Color.White;
            btnCheckStock.Font = new Font("Arial", 10, FontStyle.Bold);
            btnCheckStock.FlatStyle = FlatStyle.Flat;
            btnCheckStock.FlatAppearance.BorderSize = 1;
            btnCheckStock.FlatAppearance.BorderColor = Color.DarkBlue;

            btnBuy.BackColor = Color.ForestGreen;
            btnBuy.ForeColor = Color.White;
            btnBuy.Font = new Font("Arial", 10, FontStyle.Bold);
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.FlatAppearance.BorderSize = 1;
            btnBuy.FlatAppearance.BorderColor = Color.DarkGreen;

            UpdateDrinkInfo();
        }

        // เมื่อคลิกปุ่มเช็คสต็อก
        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            string selectedDrink = cmbDrinkOptions.SelectedItem.ToString();
            int quantity = (int)numQuantity.Value;  // Get the quantity selected by user

            bool isStockAvailable = coffeeMachine.CheckStock(selectedDrink, quantity);  // เช็คสต็อกตามจำนวนที่เลือก
            bool isIngredientsEnough = coffeeMachine.CheckIngredients(selectedDrink);

            if (isStockAvailable && isIngredientsEnough)
            {
                lblStatus.Text = $"You can buy {quantity} {selectedDrink}(s).";
                btnBuy.Enabled = true; // Enable "Buy" button only if stock and ingredients are enough
            }
            else if (!isStockAvailable)
            {
                lblStatus.Text = $"Not enough stock for {selectedDrink}. Please restock.";
                btnBuy.Enabled = false;
            }
            else if (!isIngredientsEnough)
            {
                lblStatus.Text = $"Not enough ingredients for {selectedDrink}. Please refill.";
                btnBuy.Enabled = false;
            }
        }

        // เมื่อคลิกปุ่มซื้อสินค้า
        private void btnBuy_Click(object sender, EventArgs e)
        {
            string selectedDrink = cmbDrinkOptions.SelectedItem.ToString();
            int quantity = (int)numQuantity.Value;

            // ลบสต็อกของเครื่องดื่มที่เลือกจำนวนที่ซื้อลง
            for (int i = 0; i < quantity; i++)
            {
                coffeeMachine.MakeDrink(selectedDrink);
            }

            lblStatus.Text = $"Your {quantity} {selectedDrink}(s) are ready!";
            btnBuy.Enabled = false;  // Disable "Buy" button after purchase
            UpdateDrinkInfo();  // อัพเดทข้อมูลสต็อกหลังการซื้อ
        }

        // อัพเดทข้อมูลแสดงผล
        private void UpdateDrinkInfo()
        {
            var selectedDrink = cmbDrinkOptions.SelectedItem.ToString();
            if (coffeeMachine.drinks.ContainsKey(selectedDrink))
            {
                var drink = coffeeMachine.drinks[selectedDrink];
                lblDrinkInfo.Text = $"Price: {drink.Price} THB\nStock: {drink.Stock}\nIngredients:\n Water={drink.Water}g\n Coffee={drink.Coffee}g\n Milk={drink.Milk}g\n Chocolate={drink.Chocolate}g";
                lblPrice.Text = $"Price: {drink.Price} THB";
                lblStock.Text = $"Stock: {drink.Stock}";
                lblIngredients.Text = $"Ingredients: Water={drink.Water}g, Coffee={drink.Coffee}g, Milk={drink.Milk}g, Chocolate={drink.Chocolate}g";
            }
        }

        // เมื่อคลิกปุ่มรีฟิล
        private void btnRefill_Click(object sender, EventArgs e)
        {
            coffeeMachine.RefillIngredients();
            coffeeMachine.RefillStock();
            lblStatus.Text = "Ingredients and stock refilled successfully.";
            UpdateDrinkInfo();
        }
    }

    // Class สำหรับจัดการเครื่องดื่มต่างๆ
    public class CoffeeMachine
    {
        private int Water;
        private int Coffee;
        private int Milk;
        private int Chocolate;
        public Dictionary<string, Drink> drinks;

        public CoffeeMachine()
        {
            Water = 1000;
            Coffee = 500;
            Milk = 200;
            Chocolate = 200;

            drinks = new Dictionary<string, Drink>
            {
                {"Black Coffee", new Drink("Black Coffee", 300, 20, 0, 0, 10, 50)},
                {"Mocha", new Drink("Mocha", 300, 20, 0, 10, 10, 60)},
                {"Latte", new Drink("Latte", 300, 20, 10, 0, 10, 55)},
                {"Chocolate", new Drink("Chocolate", 300, 0, 0, 20, 10, 45)}
            };
        }

        // เช็คส่วนผสมเครื่องดื่ม
        public bool CheckIngredients(string drinkName)
        {
            if (drinks.ContainsKey(drinkName))
            {
                var drink = drinks[drinkName];
                return Water >= drink.Water && Coffee >= drink.Coffee && Milk >= drink.Milk && Chocolate >= drink.Chocolate;
            }
            return false;
        }

        // เช็คสต็อกเครื่องดื่มตามจำนวนที่ต้องการซื้อ
        public bool CheckStock(string drinkName, int quantity)
        {
            if (drinks.ContainsKey(drinkName))
            {
                return drinks[drinkName].Stock >= quantity;  // เช็คว่าในสต็อกมีเพียงพอหรือไม่
            }
            return false;
        }

        // สร้างเครื่องดื่ม
        public void MakeDrink(string drinkName)
        {
            if (drinks.ContainsKey(drinkName))
            {
                var drink = drinks[drinkName];

                Water -= drink.Water;
                Coffee -= drink.Coffee;
                Milk -= drink.Milk;
                Chocolate -= drink.Chocolate;

                drink.Stock -= 1;  // ลดสต็อกของเครื่องดื่มที่เลือก
            }
        }

        // รีฟิลส่วนผสมเครื่องดื่ม
        public void RefillIngredients()
        {
            Water = 100000;
            Coffee = 50000;
            Milk = 20000;
            Chocolate = 20000;
        }

        // รีฟิลสต็อกเครื่องดื่มแต่ละชนิด
        public void RefillStock()
        {
            foreach (var drink in drinks.Values)
            {
                drink.Stock = 10;  // รีฟิลจำนวนสต็อกที่ 10 สำหรับแต่ละชนิด
            }
        }
    }

    // Class สำหรับเครื่องดื่มแต่ละชนิด
    public class Drink
    {
        public string Name { get; set; }
        public int Water { get; set; }
        public int Coffee { get; set; }
        public int Milk { get; set; }
        public int Chocolate { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

        public Drink(string name, int water, int coffee, int milk, int chocolate, int stock, int price)
        {
            Name = name;
            Water = water;
            Coffee = coffee;
            Milk = milk;
            Chocolate = chocolate;
            Stock = stock;
            Price = price;
        }
    }
}
