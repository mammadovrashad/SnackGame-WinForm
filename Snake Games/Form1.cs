using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Games
{
    
    public partial class Form1 : Form
    {
        public int _snake_quantity;
        private int _snake_size=20;
        private Random _randomLocaton;
        private Dircetion _dircetion;
        private Label snakeHeat;
        private Label mealSnake;
        private int _snake_range=2;
        List<int> resultList = new List<int>();


        public Form1()
        {
            InitializeComponent();
           _randomLocaton = new Random();
            this.Hide();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Format();

        }

        private void Format()
        {
            _snake_quantity = 0;

            CreateSnakeMeal();
            SnakeLocation();
            ChangeLocation();

            SnakeMove.Enabled = true;
            _dircetion = Dircetion.Right;
        }

        private Label CreateSnake(int locatinX,int locationY)
        {
            _snake_quantity++;
            Label   CreateSnake = new Label()
            {

                Name = "snake" + _snake_quantity,
                BackColor = Color.Red,
                Width = _snake_size,
                BorderStyle=BorderStyle.None,
                Height=_snake_size,
                Location=new Point(locatinX, locationY)
                
            };
            pnl.Controls.Add(CreateSnake);
            return CreateSnake;
           



        }
        private void SnakeLocation()
        {
            snakeHeat = CreateSnake(0,0);
            var locationX = (pnl.Width / 2)-(snakeHeat.Width/2);
            var locationY = (pnl.Height / 2)-(snakeHeat.Height/2);
            snakeHeat.Location = new Point(locationX, locationY);
        }
        private void CreateSnakeMeal()
        {
           
            Label MealSnake = new Label()
            {
                Name = "meal" ,
                BackColor = Color.Yellow,
                Width = _snake_size,
                BorderStyle = BorderStyle.FixedSingle,
                Height = _snake_size,
                

            };
          
            pnl.Controls.Add(MealSnake);
            mealSnake= MealSnake;

        }
        private void BeginAgain()
        {
            pnl.Controls.Clear();
            xal.Text = "0";
            Format();
        }
        private void ChangeLocation()
        {
            var locationX = _randomLocaton.Next(0,pnl.Width-_snake_size);
            var locationY = _randomLocaton.Next(0,pnl.Height-_snake_size);
            mealSnake.Location = new Point(locationX, locationY);
        }
        private enum Dircetion
        {
            Up,
            Down,
            Left,
            Right

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var keyCode = e.KeyCode;
            if (_dircetion is Dircetion.Left&& keyCode is Keys.D
                || _dircetion is Dircetion.Right && keyCode is Keys.A
                || _dircetion is Dircetion.Up && keyCode is Keys.Z
                || _dircetion is Dircetion.Down && keyCode is Keys.W
                )
            {
                return;
            }
            switch (keyCode)
            {
                case Keys.W:
                    _dircetion = Dircetion.Up;
                    break;
                case Keys.Z:
                    _dircetion = Dircetion.Down;
                    break;
                case Keys.A:
                    _dircetion = Dircetion.Left;
                    break;
                case Keys.D:
                    _dircetion = Dircetion.Right;
                    break;
            }
        }

        private void SnakeMove_Tick(object sender, EventArgs e)
        {


            Snake_follow();
            SnakeNorepeat();
            FinishGames();
            MealEat();
           

        }
        private void SnakeNorepeat()
        {
            var _locationX = snakeHeat.Location.X;
            var _locationY = snakeHeat.Location.Y;
            switch (_dircetion)
            {

                case Dircetion.Up:
                    snakeHeat.Location = new Point(_locationX, _locationY - (snakeHeat.Width + _snake_range));
                    break;
                case Dircetion.Down:
                    snakeHeat.Location = new Point(_locationX, _locationY + (snakeHeat.Width + _snake_range));
                    break;
                case Dircetion.Left:
                    snakeHeat.Location = new Point(_locationX - (snakeHeat.Width + _snake_range), _locationY);
                    break;
                case Dircetion.Right:
                    snakeHeat.Location = new Point(_locationX + (snakeHeat.Width + _snake_range), _locationY);
                    break;

            }

        }
        public void MealEat()
        {

            var rect1 = new Rectangle(snakeHeat.Location, snakeHeat.Size);
            var rect2 = new Rectangle(mealSnake.Location, mealSnake.Size);
            if (rect1.IntersectsWith(rect2))
            {

                xal.Text = (int.Parse(xal.Text) + 10).ToString();
                ChangeLocation();
                CreateSnake(-_snake_size,-_snake_size);
            }
        }
        private void Snake_follow()
        {
            if (_snake_quantity <= 1) return;


            for (int i = _snake_quantity; i > 1; i--)
            {
                var nextPart = (Label)pnl.Controls[i];
                var firstPart = (Label)pnl.Controls[i - 1];
                nextPart.Location = firstPart.Location;
            }
        }
        private void FinishGames()
        {
            bool _touch = false;
            var rect1 = new Rectangle(snakeHeat.Location, snakeHeat.Size);
            foreach(Control control in pnl.Controls)
            {
                if(control is Label &&control.Name.Contains("snake") && control.Name != snakeHeat.Name)
                {
                    var rect2 = new Rectangle(control.Location, control.Size);
                    if (rect1.IntersectsWith(rect2))
                    {
                        _touch = true;
                        resultList.Add(int.Parse(xal.Text));
                        break;
                    }
                }
            }
            if (_touch)
            {
                SnakeMove.Enabled = false;
                DialogResult result = MessageBox.Show($"Topladiginiz xal :{xal.Text}   yeniden baslamaq isterdiniz ?","Finis",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    BeginAgain();
                    var _maxValue= resultList.Max();
                    MaxXal.Text = $"{_maxValue.ToString()}";
                    
                }
            }
           
        }
    }
}
