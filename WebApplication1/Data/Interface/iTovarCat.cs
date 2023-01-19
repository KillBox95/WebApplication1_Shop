using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interface
{
    public interface iTovarCat
    {
        IEnumerable<Category> Allcategorys { get; }
    }
}
