using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamContacts.Model;

namespace XamContacts.ViewModel
{
    public class ContactDeteilPageViewModel
    {
        public Command SaveContactCommand { get; set; }
        public Contact CurrentContact { get; set; }
        public INavigation Navigation { get; set; }

        public ContactDeteilPageViewModel(INavigation navigation, Contact contact = null)
        {
            Navigation = navigation;
            if (contact == null)
            {
                CurrentContact = new Contact();
            }
            else
            {
                CurrentContact = contact;
            }
            
            SaveContactCommand = new Command(async() => await SaveContact());

        }

        public async Task SaveContact()
        {
            //await App.Database.SaveItemAsync(CurrentContact);
            //await ContactsManager.DefaultManager.SaveItemAsync(CurrentContact);
            await App.CloudService.GetTableAsync<Contact>().Result.SavetemAsync(CurrentContact);
            await Navigation.PopToRootAsync();
        }
    }
}
