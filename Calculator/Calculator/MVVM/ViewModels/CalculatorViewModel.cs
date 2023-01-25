using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Dangl.Calculator;

namespace Calculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand OperationCommand =>
            new Command((number) => { Formula += number; });

        public ICommand ResetCommand => new Command(() => {
            Result= "0";
            Formula= ""; });

        public ICommand DeleteCommand => new Command(() =>
        {
            if (Formula.Length > 0)
            {
                Formula = Formula.Substring(0, Formula.Length - 1);
            }
        });

        public ICommand CalculateCommand => new Command(() =>
        {
            if (Formula.Length == 0)
                return;
           var  calculation = Dangl.Calculator.Calculator.Calculate(Formula);   
           Result = calculation.Result.ToString();


        });

    }
        
}
