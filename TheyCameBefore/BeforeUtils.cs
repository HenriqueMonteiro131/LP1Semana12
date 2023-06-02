using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class BeforeUtils
{
    public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T target) where T : struct, IComparable<T>
    {
        bool foundTarget = false;
        foreach (T item in items)
        {
            if (item.CompareTo(target) == 0)
            {
                foundTarget = true;
                break;
            }

            yield return item;
        }

        if (!foundTarget)
        {
            throw new ArgumentException("O item alvo não foi encontrado no enumerável.");
        }
    }

}
