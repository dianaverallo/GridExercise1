﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Xamarin.Forms.Button;
using Android.Content;
using Android.Graphics.Drawables;
using GridExercise1.Droid.CustomRenderer;
using GridExercise1.CustomRenderer;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButton_Droid))]

namespace GridExercise1.Droid.CustomRenderer
{
    class CustomButton_Droid : ButtonRenderer
    {
        public CustomButton_Droid (Context context) : base (context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null) return;
            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid(Color.FromRgb(255, 215, 0)));
            gradientDrawable.SetStroke(4,Element.BorderColor.ToAndroid());
            gradientDrawable.SetCornerRadius(30.0f);
            Control.SetBackground(gradientDrawable);

        }
    }
}