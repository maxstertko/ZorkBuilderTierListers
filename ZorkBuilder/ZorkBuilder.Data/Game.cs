using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZorkBuilder.Data
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public World World { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Neighbor> Neighbors { get; set; }

        public Game() {
            World = new World();
            Rooms = new List<Room>();
            Neighbors = new List<Neighbor>();
        }
    }
}
