﻿using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD aCD = new CD("Jonny Lang");
            DVD aDVD = new DVD("Mama Mia");

            // TODO: Call each CD and DVD method to verify that they work as expected.
            aCD.SpinDisc();
            aCD.StoreData();
            aCD.ReportDiscInfo();

            aDVD.SpinDisc();
            aDVD.StoreData();
            aDVD.ReportDiscInfo();
        }
    }
}