﻿//  Problem 4. Rectangles

/* Write an expression that calculates rectangle’s perimeter and area by given width and height.
 * 
 * Examples:
 * width 	height 	perimeter 	area
 * 3 	    4 	    14 	        12
 * 2.5 	    3 	    11 	        7.5
 * 5 	    5 	    20 	        25 
 */

using System;

class Rectangles
{
    static void Main()
    {
        // sets console window and buffer size (width, height)
        Console.SetWindowSize(82, 20);
        Console.SetBufferSize(82, 146);

        string intro = @"This program calculates rectangle’s perimeter and area by given width and height.";
        Console.WriteLine(intro);

        string inputW;
        float yourWidth;

        string inputH;
        float yourHeight;

        do // validates width input
        {
            Console.Write("\nPlease, enter any width value of your choice: ");
            inputW = Console.ReadLine(); 

        } while (!float.TryParse(inputW, out yourWidth));


        do // validates height input
        {
            Console.Write("\nPlease, enter any height value of your choice: ");
            inputH = Console.ReadLine(); 

        } while (!float.TryParse(inputH, out yourHeight));

        // prints width, height; perimeter ((width + height) * 2); area (width * height)
        Console.WriteLine("\nRectangle with a width = {0}, and a height = {1}; Perimeter = {2};  Area = {3}\n", yourWidth , yourHeight, ((yourWidth + yourHeight) * 2), (yourWidth * yourHeight));
    }
}


