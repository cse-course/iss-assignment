using System;
using System.Data;

namespace DAL
{
    public interface IProfileClassicRepository
    {
        Boolean Add(String profile);
        Boolean Update(String profile);
        Boolean Remove(String profile);

        DataSet View();
        DataSet View(String profile);

    }
}
