using System;

namespace DBApp.Models
{
    public class Game
    {
        private int _id;
        private String name;
        private String price;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Price
        {
            get => price;
            set => price = value;
        }
    }
}