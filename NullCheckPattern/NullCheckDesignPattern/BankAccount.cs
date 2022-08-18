using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheckDesignPattern
{
    public class BankAccount
    {
        private ILog _log;
        private int balance;

        public BankAccount([CanBeNull]ILog log)
        {
            this._log = log;
            //if (log == null)
            //{
            //    throw new ArgumentNullException(paramName: nameof(log));
            //}
        }

        public void Deposit(int amount)
        {
            balance += amount;
            _log?.Info($"Deposited {amount}, balance is now {balance}");
        }
    }
}
