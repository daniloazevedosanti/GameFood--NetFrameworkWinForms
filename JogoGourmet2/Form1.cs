using GameFood.Controller;
using GameFood.Model;
using System;
using System.Windows.Forms;

namespace GameFood
{
    public partial class Form1 : Form
    {
        
        public ManagerFood ManagerFood { get; set; }        

        public FoodList FoodList { get; set; }


        public Form1()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void LoadDefaults()
        {            
            FoodList = new FoodList();         
            ManagerFood = new ManagerFood(FoodList);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            ManagerFood.StartGame();
        }
    }
}
