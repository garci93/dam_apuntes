using BDDemo2.MVVM.Model;
using Bogus;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BDDemo2.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CustomerViewModel
    {



        public List<Customer> Customers { get; set; }

        public Customer CurrentCustomer { get; set; }

        public ICommand AddOrUpdateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public CustomerViewModel()
        {
            Refresh();
            GenerateNewCustomers();
        }

        private void GenerateNewCustomers()
        {
            CurrentCustomer = new Faker<Customer>().RuleFor(x => x.Name, f => f.Person.FullName).RuleFor(x => x.Address, f => f.Person.Address.Street).Generate();

            //CurrentCustomer.Passport = new Passport
            //{
            //    ExpirationDate = DateTime.Now.AddDays(30)
            //};


            CurrentCustomer.Passport = new List<Passport>
            {
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(30)
                },
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(15)
                }
            };


            AddOrUpdateCommand = new Command(async () =>
            {
                //App.CustomerRepo.SaveItem(CurrentCustomer);

                App.CustomerRepo.SaveItemWithChildren(CurrentCustomer);

                Console.WriteLine(App.CustomerRepo.StatusMessage);
                GenerateNewCustomers();
                Refresh();

            });

            DeleteCommand = new Command(() =>
            {
                App.CustomerRepo.DeleteItem(CurrentCustomer);
                Refresh();
            });

        }

        private void Refresh()
        {
            //Customers = App.CustomerRepo.GetItems();

            //Métodos para flexibilizar las consultas con expresiones Lambda - cambiamos
            //Customers = App.CustomerRepo.GetItems(x => x.Name.StartsWith("A"));

            Customers = App.CustomerRepo.GetItemWithChildren();

        }


    }
}

