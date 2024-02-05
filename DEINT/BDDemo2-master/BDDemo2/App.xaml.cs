using BDDemo2.MVVM.Model;
using BDDemo2.MVVM.View;
using BDDemo2.Repository;

namespace BDDemo2
{
    public partial class App : Application
    {

        public static BaseRepository<Customer> CustomerRepo { get; private set; }
        public static BaseRepository<Order> OrdersRepo { get; private set; }

        public static BaseRepository<Passport> PassportRepo { get; private set; }


        public App(BaseRepository<Customer> repo, BaseRepository<Order> ordersRepo, BaseRepository<Passport> passportRepo)
        {
            InitializeComponent();
            CustomerRepo = repo;
            OrdersRepo = ordersRepo;
            PassportRepo = passportRepo;


            MainPage = new CustomerView();
        }


    }
}
