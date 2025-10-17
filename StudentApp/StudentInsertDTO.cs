using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    // Immutable, init-only, primary constructor (same order), ToString(), ==
    internal record StudentInsertDTO(string? Firstname, string? Lastname);
}