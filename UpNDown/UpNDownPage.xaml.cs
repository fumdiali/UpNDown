using System;
using Xamarin.Forms;

/*
 * Coding practice for xamarin
 * Program simply increments and decrements a value
 * Built April 22, 2018 by BigPictureDisciple
 */

namespace UpNDown
{
    public partial class UpNDownPage : ContentPage
    {
        
        int count = 0;

        public UpNDownPage()
        {
            InitializeComponent();
        }

        void OnDecrement(object sender, EventArgs e){
            if (count <= 0)
            {
                label.Text = ""+count;

            }else{
                count--;
                label.Text = "" + count;
            }
        }

        void OnIncrement(object sender, EventArgs e){
            count++;
            label.Text = ""+count;
            //countDisplayLabel += "{Binding Value, StringFormat='{count}'}";

        }
    }
}
