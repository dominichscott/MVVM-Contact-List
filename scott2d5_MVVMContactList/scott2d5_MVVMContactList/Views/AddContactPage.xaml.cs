using scott2d5_MVVMContactList.ViewModels;

namespace scott2d5_MVVMContactList.Views;

public partial class AddContactPage : ContentPage
{
   public AddContactPage(ContactsViewModel contactsViewModel)
   {
      InitializeComponent();
      BindingContext = new AddContactViewModel(contactsViewModel);
   }

   
   public AddContactPage()
   {
      InitializeComponent();
      var sharedContactsViewModel = new ContactsViewModel();
      BindingContext = new AddContactViewModel(sharedContactsViewModel);
   }
   
}