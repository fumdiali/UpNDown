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
                above20.Text = "";
                label.Text = "" + count;
                if (count < 5){
                    above20.Text = "Oh, you deserve a cookie..";
                    if(count == 0){ above20.Text = "Cookieeeeee!!!"; }
                }else if (count <= 10){
                    above20.Text = "Very good, keep going..";
                }else{
                    above20.Text = "Good..";
                }
            }
        }

        void OnIncrement(object sender, EventArgs e){
            if (count > 19)
            {
                above20.Text = "Oops! At 20,you're done. Go Down..";
            }
            else
            {
                count++;
                above20.Text = "Good. Higher..";
                if (count >= 10){
                    above20.Text = "Higher..Higher..";
                }
                if (count >= 15){
                    above20.Text = "Don't stop! Don't stop...";
                }
                label.Text = "" + count;
                //countDisplayLabel += "{Binding Value, StringFormat='{count}'}";
            }

        }
    }
}
