/*   _____  _                              
    /  ___|| |                             
    \ `--. | |__    __ _  _ __    ___  ___ 
     `--. \| '_ \  / _` || '_ \  / _ \/ __|
    /\__/ /| | | || (_| || |_) ||  __/\__ \
    \____/ |_| |_| \__,_|| .__/  \___||___/
                     | |               
                     |_|                        */    

/* Author: Erik Humphrey
 * Project title: Project 21 - Shapes
 * Date started: December 13th 2015
 * Executable name: HumphreyErik20Shapes.exe
 * Description: Program that repetitively draws random coloured ellipses, rectangles, and lines
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErik21Shapes
{
    public partial class frmShapeDemo : Form
    {
        // Global declarations
        Graphics myGraphics;
        Pen myPen;
        Random rnd = new Random();

        int point;
        string shape = "Ellipse";

        bool drewSomething = false;

        public frmShapeDemo()
        {
            InitializeComponent();
        }

        private void frmShapeDemo_Load(object sender, EventArgs e)
        {
            myGraphics = pnlDraw.CreateGraphics(); // Convert panel to graphics object
        }

        private void frmShapeDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Free up system resources by disposing pen and graphics objects
            if (drewSomething) // Prevent program from throwing an exception if it's closed without anything being drawn
               myPen.Dispose(); 
            myGraphics.Dispose();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            drewSomething = true;
            tmrShape.Enabled = true; // Start a drawing
            myGraphics.Clear(pnlDraw.BackColor); // Clear existing drawing
        }

        // Set selected shape when radio button is checked

        private void radEllipse_CheckedChanged(object sender, EventArgs e)
        {
            shape = "Ellipse";
        }

        private void radRectangle_CheckedChanged(object sender, EventArgs e)
        {
            shape = "Rectangle";
        }

        private void radLine_CheckedChanged(object sender, EventArgs e)
        {
            shape = "Line";
        }

        private void tmrShape_Tick(object sender, EventArgs e)
        {
            // Create a new random pen colour
            myPen = new Pen(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));

            if (shape == "Ellipse")
            {
                // Draw ellipse 
                myGraphics.DrawEllipse(myPen, point, point, pnlDraw.Width - 2 * point, pnlDraw.Height - 2 * point); // Make shape smaller
            }
            else if (shape == "Rectangle")
            {
                // Draw rectangle
                myGraphics.DrawRectangle(myPen, point, point, pnlDraw.Width - 2 * point, pnlDraw.Height - 2 * point);
            }
            else if (shape == "Line")
            {
                // Draw line
                myGraphics.DrawLine(myPen, point, point, pnlDraw.Width - 2 * point, pnlDraw.Height - 2 * point);
            }

            point = point + (int)myPen.Width;

            if (point > pnlDraw.Height / 2)
            {
                point = 0;
                tmrShape.Stop();
            }
        }
    }
}
