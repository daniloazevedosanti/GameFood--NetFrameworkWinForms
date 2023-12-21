using GameFood.Model;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameFood.Controller
{
    public class ManagerFood
    {
        public FoodList FoodList { get; set; }
        public int Count { get; set; }  = 0;

        public ManagerFood(FoodList foodList)
        {
            FoodList = foodList;
        }

        public void StartGame()
        {
            ValidationTypeFood(FoodList.PlateFood);
        }

        private void ValidationTypeFood(List<Food> foods)
        {
            var foodFilter = foods.Where(x => !string.IsNullOrEmpty(x.Type))
                                     .OrderByDescending(x => !string.IsNullOrEmpty(x.Type));

            foreach (var item in foodFilter)
            {
                var result = ShowMessage($"O prato que você pensou é {(string.IsNullOrEmpty(item.Type) ? item.Name : item.Type)}?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ToCheckFood(item);
                    break;
                }

                if (item == foodFilter.Last())
                    ToCheckFood(foods.Where(x => string.IsNullOrEmpty(x.Type)).FirstOrDefault(), foods);
            }
        }

        private void Quit(Food prato, List<Food> pratos = null)
        {
            var pratoInformado = ShowMessageInput("Qual prato você pensou?", "Desisto");

            var tipo = ShowMessageInput($"{pratoInformado} é ________ mas {prato.Name} não.", "Complete");

            if (pratos.Any())
            {
                pratos.Add(new Food()
                {
                    Name = pratoInformado,
                    Type = tipo
                });
            }
            else
                prato.NewFood.Add(new Food()
                {
                    Name = pratoInformado,
                    Type = tipo
                });
        }

        private void ToCheckFood(Food food, List<Food> foods = null)
        {
            if (food.NewFood.Any())
            {
                if (CheckWithNewElements(food.NewFood, true)) return;
            }

            var result = ShowMessage($"O prato que você pensou é {food.Name}?", "Confirm", MessageBoxButtons.YesNo);
            

            if (result == DialogResult.Yes)
            {

                GetMessageAcerto(Count);
                Count++;
                return;
            }
            

            Quit(food, foods ?? new List<Food>());
        }

        private bool CheckWithNewElements(List<Food> foodsList, bool isNewFood = false)
        {
            foreach (var item in foodsList)
            {
                if (item.NewFood.Any() && !isNewFood)
                {
                    if (CheckWithNewElements(item.NewFood, true))
                        break;
                }

                var result = ShowMessage($"O prato que você pensou é {item.Type}?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ToCheckFood(item);
                    return true;
                }
            }

            return false;
        }

        private DialogResult ShowMessage(string message, string msgConfirm, MessageBoxButtons buttons)
        {
            return MessageBox.Show(message, msgConfirm, buttons);
        }

        private void GetMessageAcerto(int count)
        {
            if (count > 0)
                MessageBox.Show("Acertei de novo!", "GameFood", MessageBoxButtons.OK);
            else
                MessageBox.Show("Acertei!", "GameFood", MessageBoxButtons.OK);

        }

        private string ShowMessageInput(string msg, string confirm)
        {
            return Interaction.InputBox(msg, confirm);
        }
    }
}
