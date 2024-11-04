namespace BankAccount_XunitTesting
{
    public class UnitTest1
    {
        private BankAccount account;

        public UnitTest1()
        {
            account = new BankAccount(100);
        }

        [Fact]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            account.Deposit(50);
            Assert.Equal(150, account.GetBalance());
        }

        [Fact]
        public void Deposit_NegativeAmount_Throws_DepositAmountMustBePositive()
        {
            Assert.Throws<DepositAmountMustBePositive>(() => account.Deposit(-10));
        }

      

        [Fact]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            account.Withdraw(50);
            Assert.Equal(50, account.GetBalance());
        }

        [Fact]
        public void Withdraw_AmountMoreThanBalance_ThrowsInvalidOperationException()
        {
            Assert.Throws<InSufficientBalanceException>(() => account.Withdraw(200));
        }

        [Fact]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<Exception>(() => account.Withdraw(-10));
        }


        [Fact]
        public void GetBalance_ReturnsCorrectBalance()
        {
            Assert.Equal(100, account.GetBalance());
        }

        [Fact]
        public void Transfer_ValidAmount_DecreasesSourceAndIncreasesDestinationBalance()
        {
            var targetAccount = new BankAccount(50);
            account.Transfer(targetAccount, 30);

            Assert.Equal(70, account.GetBalance());
            Assert.Equal(80, targetAccount.GetBalance());
        }

        [Fact]
        public void Transfer_AmountMoreThanBalance_ThrowsInvalidOperationException()
        {
            var targetAccount = new BankAccount();
            Assert.Throws<InvalidOperationException>(() => account.Transfer(targetAccount, 200));
        }

        [Fact]
        public void Transfer_ToNullAccount_ThrowsArgumentNullException()
        {
            Assert.Throws<TargetCannotBeNullException>(() => account.Transfer(null, 50));
        }

        [Fact]
        public void Transfer_NegativeAmount_Throws_AmountMustBePositive()
        {
            var targetAccount = new BankAccount();
            Assert.Throws<AmountMustBePositive>(() => account.Transfer(targetAccount, -50));
        }

    }
}