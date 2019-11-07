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
using Newtonsoft.Json;
using Zork;
namespace ZorkBuilder.WinForms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTile = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

        private WorldViewModel ViewModel {
            get => mViewmodel;
            set {
                if(mViewmodel != value) {
                    mViewmodel = value;
                    worldViewModelBindingSource.DataSource = mViewmodel;
                }
            }
        }

        private bool IsGameLoaded {
            get => mIsGameLoaded;
            set {
                mIsGameLoaded = value;
                tabControl.Enabled = mIsGameLoaded;
            }
        }

        public MainForm() {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsGameLoaded = false;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e) {
            if(createNewDialog.ShowDialog() == DialogResult.OK) {
                ViewModel.Filename = createNewDialog.Filename;
                ViewModel.Rooms = new BindingList<Room> { new Room { Name = "Start" } };
                ViewModel.SaveGame();
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(createNewDialog.FileName));
                ViewModel.Game = game;
                IsGameLoaded = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Game = game;
                ViewModel.Filename = openFileDialog.FileName;
                IsGameLoaded = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Label2_Click(object sender, EventArgs e) {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private WorldViewModel mViewmodel;
        private bool mIsGameLoaded;

        
    }
}
