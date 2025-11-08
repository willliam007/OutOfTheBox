using System;
using Microsoft.Maui.Handlers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Graphics;
#if ANDROID
using Microsoft.Maui.Platform;
#endif

namespace OutOfTheBox.Controls
{
    public class NoUnderlineEntry : Entry
    {
        protected override void OnHandlerChanged()
        {
            base.OnHandlerChanged();
            RemoveUnderline();
        }
        protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == nameof(BackgroundColor)) 
            { 
                RemoveUnderline();
            }
        }

        private void RemoveUnderline() 
        {
#if ANDROID
           if(Handler is IEntryHandler entryHandler)
            {
               if(BackgroundColor == null)

                {
                    entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
                }
                else
                {
                    entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(BackgroundColor.ToPlatform());
                }
            }
#endif
        }
    }
}
