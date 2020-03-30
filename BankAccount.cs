namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                System.Console.WriteLine("Please enter a positive number");
            }else
            {
                _balance = _balance + amount;
            }
        }

        public void Withdraw(double amount)
        {
            if(amount <= 0){
                System.Console.WriteLine("Please enter a positive number");
            }
            else if(amount <= _balance)
            {
                _balance = _balance - amount;
            }else
            {
                System.Console.WriteLine("You do not have that much money bitch");
            }
        } 
        #endregion
    }
}