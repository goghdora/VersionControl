using Ajándék_futószalag.Abstractions;
using Ajándék_futószalag.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajándék_futószalag
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();

        private Toy _nextToy;

        private IToyFactory _factory;
        public IToyFactory IToyFactory
        {
            get { return _factory; }
            set { _factory = value; }
        }
        public Form1()
        {
            InitializeComponent();
            //IToyFactory = new IToyFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = IToyFactory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IToyFactory = new CarFactory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            IToyFactory = new BallFactory
            {
                BallColor = button3.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = IToyFactory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IToyFactory = new BallFactory
            {
                BallColor = button3.BackColor
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IToyFactory = new BallFactory
            {
                BallColor = button5.BackColor
            };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IToyFactory = new BallFactory
            {
                BallColor = button6.BackColor
            };
        }
    }
}
