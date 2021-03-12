using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.ImageEdit;
using Xamarin.Forms;

namespace WithoutBugs.Models
{
    public class Tile
    {
       
        private const string newPath =
            "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Flokeshdhakar.com%2Fprojects%2Flightbox2%2Fimages%2Fimage-5.jpg&f=1&nofb=1";

        public int I { get; private set; }

        
        public Tile(int row, int col)
        {
            Row = row;
            Col = col;


           TileView = new ContentView
            {
                Padding = new Thickness(1),
                Content = new Image
                {
                    Source = ImageSource.FromUri(new Uri(newPath + "Bitmap" + row + col + ".png"))
                }
        };

          




            // Add TileView to dictionary for obtaining Tile from TileView
            Dictionary.Add(TileView, this);
        }

        /// <summary>
        /// https://github.com/muak/Xamarin.Plugin.ImageEdit TODO
        /// </summary>
        /// <returns></returns>
        //public async Task CropBitches()
        //{
        //    var image = await CrossImageEdit.Current.CreateImageAsync(imageStream);
        //}


        public static Dictionary<View, Tile> Dictionary { get; } = new Dictionary<View, Tile>();

            public int Row { set; get; }

            public int Col { set; get; }

            public View TileView { private set; get; }



        }

}