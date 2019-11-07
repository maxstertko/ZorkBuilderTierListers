using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZorkBuilder.Data;
using ZorkBuilder.Forms.ViewModels;
using Newtonsoft.Json;

namespace ZorkBuilder.Forms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
        private WorldViewModel ViewModel {
            get => mViewModel;
            set {
                if (mViewModel != value) {
                    mViewModel = value;
                    //insert binding source
                }
            }
        }
        private bool IsGameLoaded {
            get => mIsGameLoaded;
            set {
                mIsGameLoaded = value;
                gameControl.Enabled = mIsGameLoaded;
            }
        }
        public MainForm() {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsGameLoaded = false;
        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e) {
            if (createNewDialog.ShowDialog() == DialogResult.OK) {
                ViewModel.Filename = createNewDialog.FileName;
                ViewModel.Rooms = new BindingList<Room> { new Room { Name = "Start" } };
                ViewModel.SaveGame();
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(createNewDialog.FileName));
                ViewModel.Game = game;
                IsGameLoaded = true;
            }
        }

        private WorldViewModel mViewModel;
        private bool mIsGameLoaded;

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Game = game;
                ViewModel.Filename = openFileDialog.FileName;
                IsGameLoaded = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveGame();

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveGame();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
