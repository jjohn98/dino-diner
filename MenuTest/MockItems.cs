using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;


namespace MenuTest
{
    public class MockItems : IOrderItem, INotifyPropertyChanged
    {
        public double Price { get; set; }

        public string Description { get; set; }

        public string[] Special { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public class MockItem1 : IOrderItem, INotifyPropertyChanged
        {
            public double Price { get; set; } = 4;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;

            public MockItem1(double price)
            {
                this.Price = price;
            }

            public MockItem1()
            {

            }
        }

        public class MockItem2 : IOrderItem, INotifyPropertyChanged
        {
            public double Price { get; set; } = 8;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;

            public MockItem2(double price)
            {
                this.Price = price;
            }

            public MockItem2()
            {

            }
        }

        public class MockItem3 : IOrderItem, INotifyPropertyChanged
        {
            public double Price { get; set; } = 5;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;

            public MockItem3(double price)
            {
                this.Price = price;
            }

            public MockItem3()
            {

            }
        }
    }
}
