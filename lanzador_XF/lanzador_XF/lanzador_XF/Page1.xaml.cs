﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lanzador_XF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : CarouselPage
    {
        public Page1()
        {
            InitializeComponent();
        }
    }
}