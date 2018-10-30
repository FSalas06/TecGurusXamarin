using Android.Content;
using Android.Graphics;
using Android.Widget;
using TGXFExampleApp.Droid.CustomRenderers;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Xamarin.Forms.Switch), typeof(CustomSwitch))]
namespace TGXFExampleApp.Droid.CustomRenderers
{
    public class CustomSwitch : SwitchRenderer
    {
        public CustomSwitch(Context context) : base(context)
        {
        }

        private Color redColor = new Color(255, 0, 0);
        private Color greenColor = new Color(32, 156, 68);

        protected override void Dispose(bool disposing)
        {
            this.Control.CheckedChange -= this.OnCheckedChange;
            base.Dispose(disposing);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                if (this.Control.Checked)
                {
                    this.Control.ThumbDrawable.SetColorFilter(greenColor, PorterDuff.Mode.SrcAtop);
                }
                else
                {
                    this.Control.ThumbDrawable.SetColorFilter(redColor, PorterDuff.Mode.SrcAtop);
                }

                this.Control.CheckedChange += this.OnCheckedChange;
            }
        }

        private void OnCheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (this.Control.Checked)
            {
                this.Control.ThumbDrawable.SetColorFilter(greenColor, PorterDuff.Mode.SrcAtop);
            }
            else
            {
                this.Control.ThumbDrawable.SetColorFilter(redColor, PorterDuff.Mode.SrcAtop);
            }
        }
    }
}