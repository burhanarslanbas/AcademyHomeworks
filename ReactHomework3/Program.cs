using ReactHomework3.Question2;

// Vadeli Hesap Örneği
SavingsAccount savingsAccount = new SavingsAccount();
savingsAccount.AccountHolder = "Burhanettin Arslanbaş";
savingsAccount.AccountNumber = "111111";
savingsAccount.Balance = 8500;

// Vadesiz Hesap Örneği
CheckingAccount checkingAccount = new CheckingAccount();
checkingAccount.AccountHolder = "Yiğit Arslanbaş";
checkingAccount.AccountNumber = "222222";
checkingAccount.Balance = 5600;

savingsAccount.CalculateInterest();
checkingAccount.CalculateInterest();