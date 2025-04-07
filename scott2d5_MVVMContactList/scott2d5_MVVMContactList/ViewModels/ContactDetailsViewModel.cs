using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contact = scott2d5_MVVMContactList.Models.Contact;

namespace scott2d5_MVVMContactList.ViewModels
{
   public partial class ContactDetailsViewModel : ObservableObject
   {
      [ObservableProperty] public Contact contact;

      [RelayCommand]
      private async Task GoBack()
      {
         await Shell.Current.GoToAsync("..");
        }
   }
}
