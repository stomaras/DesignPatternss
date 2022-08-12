using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Domain.Lazy
{
    public interface IValueHolder<T>
    {
        // A value holder needs a way for it to return the value back to the consumer 
        // of the value holder
        T GetValue(object parameter);
    }
}
