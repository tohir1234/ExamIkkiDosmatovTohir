using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamIkkiDosmatovTohir.Extensions;


public static  class MovieExtensions
{

    public static int DurationMinutes(this int minut)
    {
        return minut / 60 / 60;
    }


}
