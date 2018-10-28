using System;
using Xamarin.Forms;

namespace CircularButton
{
    public class CircularButton : Button
    {
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            CornerRadius = (int) width / 2;
        }
    }
}
