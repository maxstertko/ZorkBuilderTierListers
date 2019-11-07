using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZorkBuilder.Data
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }
    }
}
