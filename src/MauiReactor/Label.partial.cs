﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor
{
    public partial class Label
    {
        public Label(object? text) => this.Text(text?.ToString() ?? string.Empty);

        public Label(Func<string> textFunc) => this.Text(textFunc);
    }
}
