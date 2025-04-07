using scott2d5_MVVMContactList.ViewModels;

namespace scott2d5_MVVMContactList.Views;
using Contact = scott2d5_MVVMContactList.Models.Contact;

public partial class ContactsPage : ContentPage
{
   public ContactsPage(ContactsViewModel contactsViewModel)
   {
      InitializeComponent();
      BindingContext = contactsViewModel;
   }

   private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
   {
      if (e.CurrentSelection.FirstOrDefault() is Contact selectedContact)
      {
         await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
      }
   }
}