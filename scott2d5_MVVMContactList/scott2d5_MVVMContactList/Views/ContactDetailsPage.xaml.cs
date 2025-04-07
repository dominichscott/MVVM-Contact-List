using scott2d5_MVVMContactList.ViewModels;

namespace scott2d5_MVVMContactList.Views;
using Contact = scott2d5_MVVMContactList.Models.Contact;

public partial class ContactDetailsPage : ContentPage
{
   public ContactDetailsPage(Contact selectedContact)
   {
      InitializeComponent();
      BindingContext = new ContactDetailsViewModel
      {
         contact = selectedContact
      };
   }
}