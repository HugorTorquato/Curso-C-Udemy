namespace Demo1.Entities
{
    abstract class Account // ->Herançatotal,só pode instanciar objetos das subclasses
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            // Método definido como virtual já que pode ser sobreescrito na classe secundária
            // SavingsAccount nesse caso

            // Pode ser sobreescrito nas subclasses

            Balance -= (amount + 5);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // Um método abstrato pode ser usado quando não tem como implementar a função pela
        // subclasser ser muito genérica. Logo, esse método tem de ser abstrato para deligar
        // afunção
        // Ela ainda tem de ser implementada dado o polimorfismo, de forma a poder aproveitar
        // todas as vantagens do polimorfismo.
    }
}
