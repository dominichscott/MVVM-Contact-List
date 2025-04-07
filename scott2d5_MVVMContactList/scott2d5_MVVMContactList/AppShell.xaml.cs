using scott2d5_MVVMContactList.Views;

namespace scott2d5_MVVMContactList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("AddContactPage", typeof(AddContactPage));
            Routing.RegisterRoute("ContactsPage", typeof(ContactsPage));
            Routing.RegisterRoute("ContactDetailsPage", typeof(ContactDetailsPage));
            InitializeComponent();
        }
    }
}
