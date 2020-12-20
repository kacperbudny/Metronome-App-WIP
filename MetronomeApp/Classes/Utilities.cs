﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MetronomeApp.Classes
{
    public static class Utilities
    {
        public static bool AllowNumericInputOnly(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            return regex.IsMatch(e.Text);
        }

        public static bool BlockSpaceInput(KeyEventArgs e)
        {
            return e.Key == Key.Space;
        }
    }
}
