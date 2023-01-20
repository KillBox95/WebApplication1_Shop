using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interface
{
    public interface iAllTovars
    {
        IEnumerable<Tovar> Tovars { get; }
        IEnumerable<Tovar> getFavTovar { get; }
        Tovar getObjectTovar(int TovarId);
    }
}
