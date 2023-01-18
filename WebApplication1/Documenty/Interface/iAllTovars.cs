using System.Collections;
using System.Collections.Generic;
using WebApplication1.Documenty.Modely;

namespace WebApplication1.Documenty.Interface
{
    public interface iAllTovars
    {
        IEnumerable<Tovar> Tovars { get; }
        Tovar getObjectTovar(int TovarId);
    }
}
