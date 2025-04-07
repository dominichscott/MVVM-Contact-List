using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Contact = scott2d5_MVVMContactList.Models.Contact;
using System.Xml.Linq;

namespace scott2d5_MVVMContactList.ViewModels
{
   public partial class AddContactViewModel : ObservableObject
   {
      private readonly ContactsViewModel contactsVM;

      public AddContactViewModel(ContactsViewModel contactsViewModel)
      {
         contactsVM = contactsViewModel;
      }

      [ObservableProperty] private string name;
      [ObservableProperty] private string email;
      [ObservableProperty] private string phoneNumber;
      [ObservableProperty] private string description;

      [RelayCommand]
      private async Task SaveContact()
      {
         contactsVM.Contacts.Add(new Contact
         {
            Name = Name,
            Email = Email,
            PhoneNumber = PhoneNumber,
            Description = Description
         });

         await Shell.Current.GoToAsync("///ContactsPage");
      }
   }
}
