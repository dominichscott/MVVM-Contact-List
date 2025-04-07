using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using scott2d5_MVVMContactList.Models;
using System.Collections.ObjectModel;
using Contact = scott2d5_MVVMContactList.Models.Contact;

namespace scott2d5_MVVMContactList.ViewModels
{
   public partial class ContactsViewModel : ObservableObject
   {
      public ObservableCollection<Contact> Contacts { get; set; } = new();

      [ObservableProperty]
      private Contact selectedContact;

      [RelayCommand]
      private async Task GoToAddContactPage()
      {
         await Shell.Current.GoToAsync("//AddContactPage");
      }

      [RelayCommand]
      private async Task GoToContactDetailsPage(Contact contact)
      {
         SelectedContact = contact;
         await Shell.Current.GoToAsync(nameof(Views.ContactDetailsPage));
      }
   }
}
