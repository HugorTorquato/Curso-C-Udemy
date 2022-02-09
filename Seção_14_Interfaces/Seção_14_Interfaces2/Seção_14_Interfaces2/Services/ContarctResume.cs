using System;
using System.Collections.Generic;
using System.Text;
using Seção_14_Interfaces2.Services;
using Seção_14_Interfaces2.Entities;

namespace Seção_14_Interfaces2.Services
{
    class ContarctResume
    {
        public int InstallmentsCount { get; set; }
        public List<Installments> InstallmentsList { get; set; }


        private IPayPal _bank;
        
        public ContarctResume(int installmentsCount, IPayPal bank)
        {
            InstallmentsCount = installmentsCount;
            _bank = bank;
        }

        public void ProcessInstallments(Contract contract)
        {
            InstallmentsList = _bank.Install(contract.Ammount, contract.InitialDate, InstallmentsCount);
        }
    }
}
