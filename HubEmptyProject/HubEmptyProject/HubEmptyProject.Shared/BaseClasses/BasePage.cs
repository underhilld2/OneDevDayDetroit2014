using System;
using System.Collections.Generic;
using System.Text;
using Windows.ApplicationModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using HubEmptyProject.Common;

namespace HubEmptyProject.BaseClasses
{
   public class BasePage : Page
   {
      private readonly NavigationHelper _navigationHelper;


      public BasePage()
      {
         _navigationHelper = new NavigationHelper( this );
         _navigationHelper.LoadState += navigationHelper_LoadState;
         _navigationHelper.SaveState += navigationHelper_SaveState;
      }

      public NavigationHelper NavigationHelper
      {
         get
         {
            return _navigationHelper;
         }
      }

      private void navigationHelper_LoadState( object sender, LoadStateEventArgs e )
      {
         LoadState( e );
      }

      private void navigationHelper_SaveState( object sender, SaveStateEventArgs e )
      {
         SaveState( e );
      }

      protected virtual void LoadState( LoadStateEventArgs e )
      {
      }
      protected virtual void SaveState( SaveStateEventArgs e )
      {
      }

      #region NavigationHelper registration

      protected override void OnNavigatedTo( NavigationEventArgs e )
      {
         if ( DesignMode.DesignModeEnabled )
            return;
         _navigationHelper.OnNavigatedTo( e );
      }

      protected override void OnNavigatedFrom( NavigationEventArgs e )
      {
         if ( DesignMode.DesignModeEnabled )
            return;
         _navigationHelper.OnNavigatedFrom( e );
      }

      #endregion

      protected void PageLoaded( object sender, RoutedEventArgs e )
      {
      }

      protected void PageUnloaded( object sender, RoutedEventArgs e )
      {
      }
   }
}
