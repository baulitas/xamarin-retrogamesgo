using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using RetroGamesGo.View;
using Xamarin.Forms;

namespace RetroGamesGo
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Character> _characters;
        public List<Character> Characters
        {
            get { return _characters; }
            set
            {
                _characters = value;
                OnPropertyChanged("Characters");
            }
        }

        public ICommand CaptureCommand => new Command(Capture);

        private void Capture()
        {
            var navigation = Application.Current.MainPage as CustomNavigationPage;
            if (navigation != null)
            {
                navigation.PushAsync(new CaptureView(), true);
            }
        }

        public MainPageViewModel()
        {
            LoadCharacters();
        }

        private void LoadCharacters()
        {
            Characters = new List<Character>()
            {
                new Character()
                {
                    Name = "Sonic",
                    Description = "Sonic es...",
                    ImageSource = "sonic_color.png"
                },
                new Character()
                {
                    Name = "Mario",
                    Description = "Mario es...",
                    ImageSource = "mario_color.png"
                },
                new Character()
                {
                    Name = "Donkey kong",
                    Description = "Donkey kong es...",
                    ImageSource = "king_kong_color.png"
                },
                 new Character()
                {
                    Name = "Pac Man",
                    Description = "Pac Man es...",
                    ImageSource = "pac_man_color.png"
                },
                 new Character()
                {
                    Name = "Space Invaders",
                    Description = "Space Invaders es...",
                    ImageSource = "space_invader_color.png"
                }
            };
        }
    }
}
